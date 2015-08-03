using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.Xml;

using SysproUtils.DAL;
using System.IO;

/// <summary>
/// Package used for interacting with Syspro as well as provide helper functions and
/// other utilities commonly used at Forte.
/// </summary>
namespace SysproUtils
{
    /// <summary>
    /// Base class that handles all interactivity between Syspro and your application.
    /// </summary>
    public class Foundation
    {
        #region Private Properties
        // Syspro connection client
        private IActionable sysClient;

        // Used to call appropriate client methods based on type
        private Dictionary<SysproTypes, Func<bool>> sysOpts;

        private AddonDbContext dbCtx;

        // Current logged in Syspro user info
        private UserInfo userInfo;

        private string settingsPath;

        private SysproTypes sysType;
        #endregion

        #region Public Properties
        /// <summary>
        /// Reference object to the user-defined XML settings file.
        /// </summary>
        public Settings fileSettings;

        /// <summary>
        /// Reference object to the operator Syspro settings returned from Syspro.
        /// </summary>
        public SysproSettings sysproSettings;
        #endregion

        #region Public Methods
        /// <summary>
        /// Instantiate the proper Syspro service based on passed-in type.  
        /// E.g. SysproUtils.WcfService.
        /// </summary>
        /// <param name="_sysType">Syspro connection type to use.</param>
        /// <param name="settingsPath">Path to user defined settings XML file.</param>
        public Foundation(SysproTypes _sysType, string settingsPath)
        {
            fileSettings = new Settings();
            userInfo = new UserInfo();
            sysproSettings = new SysproSettings();

            sysOpts = new Dictionary<SysproTypes, Func<bool>>()
            {
                { SysproTypes.WcfService,  NewWcf },
                { SysproTypes.COM, NewCOM }
            };

            sysType = _sysType;
        }

        /// <summary>
        /// Returns true of false if the current operator is logged in by checking
        /// to see if they have a valid GUID assigned from Syspro.
        /// </summary>
        /// <returns></returns>
        public bool isLoggedOn()
        {
            return !(userInfo.GUID == null);
        }

        /// <summary>
        /// Checks if the current Syspro user has a user/pass combo in the addon DB
        /// to auto log them in the next time the program is loaded.  Adds them to the DB
        /// if they don't exist, or updates their password if they do.
        /// </summary>
        /// <param name="username">Syspro NetworkUserName</param>
        /// <param name="password">Syspro password</param>
        /// <returns></returns>
        public bool AddUserToSql(string username, string password)
        {
            if (username == "")
                return false;

            var usr = new User()
            {
                NetworkUserName = username,
                UserPassword = password
            };

            try
            { 
                dbCtx.Users.InsertOnSubmit(usr);

                dbCtx.SubmitChanges();
                
                retrieveGUID();

                return true;
            }
            catch (Exception ex)
            {
                Logger.Log("Error creating user in SQL: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Post data to Syspro's business object.
        /// </summary>
        /// <param name="businessObject">Business object to use.</param>
        /// <param name="xmlParams">BO's parameters to use.</param>
        /// <param name="xmlIn">XML data to insert via the BO.</param>
        /// <returns></returns>
        public string Post(string businessObject, string xmlParams, string xmlIn)
        {
            var result = sysClient.Post(userInfo.GUID, businessObject, xmlParams, xmlIn);

            return result;
        }

        /// <summary>
        /// Load class data from Syspro operator XML, settings file XML, the database and
        /// instantiate a new Syspro client to use.
        /// </summary>
        /// <param name="output">XML operator returned by Syspro</param>
        /// <param name="xmlSettings">XML file path for settings file</param>
        public void LoadData(string output, string xmlSettings)
        {
            try
            {
                loadOperatorSettings(output);
                loadFileSettings(xmlSettings);
                sysOpts[sysType]();
                loadDbContext();
                retrieveGUID();
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
                throw;
            }
        }
        
        /// <summary>
        /// Return database connection info based on the settings file parameter.
        /// </summary>
        /// <param name="isAddon">Whether or not we want the 'SysproAddonDb' connection string returned.</param>
        /// <returns>Formatted connection string.</returns>
        public string SqlConnectionInfo(bool isAddon = false)
        {
            string fmt = "";

            if (isAddon)
                fmt = String.Format(fileSettings.AddonDbConnection, fileSettings.AddonDbName, 
                    fileSettings.AddonDbUser, fileSettings.AddonDbPassword);
            else
                fmt = String.Format(fileSettings.DbConnection, sysproSettings.Company,
                    fileSettings.DbUser, fileSettings.DbPassword);


            return fmt;
        }
        #endregion

        #region Private Methods
        private void loadOperatorSettings(string output)
        {
#if DEBUG
            output = File.ReadAllText(Helpers.AssemblyDirectory + "\\GetSYSPROInfo.xml");
#endif

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(output);

                XmlNodeList xnList = doc.SelectNodes("/Variables/SystemVariables");

                foreach (XmlNode item in xnList)
                {
                    sysproSettings.Operator = item["Operator"].GetAttribute("Value");
                    sysproSettings.OperatorName = item["OperatorName"].GetAttribute("Value");
                    sysproSettings.Company = item["Company"].GetAttribute("Value");
                    sysproSettings.CompanyName = item["CompanyName"].GetAttribute("Value");
                    sysproSettings.CompanyDatabaseName = item["CompanyDatabaseName"].GetAttribute("Value");
                    sysproSettings.DataSourceName = item["DataSourceName"].GetAttribute("Value");
                    sysproSettings.NetworkUserName = item["NetworkUserName"].GetAttribute("Value");
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Error loading operator settings: " + ex.Message);
                throw;
            }
        }

        private void loadFileSettings(string xmlSettings)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Settings));

            try
            {
                using (XmlReader reader = XmlReader.Create(xmlSettings))
                {
                    fileSettings = (Settings)xml.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Settings file not found: " + ex.Message);
                throw;
            }
        }

        private void retrieveGUID()
        {
            var res = (from usr in dbCtx.Users
                      where usr.NetworkUserName == sysproSettings.NetworkUserName
                      select usr).FirstOrDefault();


            if (res != null)
            {
                try
                {
                    userInfo.GUID = sysClient.Logon(res.NetworkUserName, res.UserPassword,
                        sysproSettings.Company, "");
                }
                catch (Exception ex)
                {
                    Logger.Log(ex.Message);
                }
            }
        }

        private void loadDbContext()
        {
            var conInfo = SqlConnectionInfo(true);

            dbCtx = new AddonDbContext(conInfo);

            try
            {
                dbCtx.Connection.Open();
            } 
            catch (Exception ex)
            {
                Logger.Log("Exception loading addon db: " + ex.Message);
                throw;
            }
        }

        private bool NewWcf()
        {
            try
            {
                sysClient = new WCFClient(fileSettings.WcfConnString);
            }
            catch (Exception ex)
            {
                Logger.Log("Could not connect to WCF: " + ex.Message);
                return false;
            }

            return true;
        }

        private bool NewCOM()
        {
            try
            {
                sysClient = new EncoreClient();
            }
            catch(Exception ex)
            {
                Logger.Log("Could not connect to COM: " + ex.Message);
                return false;
            }

            return true;
        }
        #endregion
    }
}
