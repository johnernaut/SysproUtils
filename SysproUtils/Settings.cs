using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SysproUtils
{
    /// <summary>
    /// Settings class loaded from user-specified XML file.
    /// </summary>
    [Serializable(), XmlRoot("settings")]
    public class Settings
    {
        #region Private Properties
        private string _dbConnection;
        private string _dbName;
        private string _dbUser;
        private string _dbPassword;

        private string _addonDbUser;
        private string _addonDbPassword;
        private string _addonDbConnection;
        private string _addonDbName;

        private string _wcfConnString;
        private string _apSupplier;
        #endregion

        #region Public Properties
        [System.Xml.Serialization.XmlElement("DbConnection")]
        public string DbConnection
        {
            get
            {
                return _dbConnection;
            }
            set
            {
                _dbConnection = value;
            }
        }

        [System.Xml.Serialization.XmlElement("DbName")]
        public string DbName
        {
            get
            {
                return _dbName;
            }
            set
            {
                _dbName = value;
            }
        }

        [System.Xml.Serialization.XmlElement("DbUser")]
        public string DbUser
        {
            get
            {
                return _dbUser;
            }
            set
            {
                _dbUser = value;
            }
        }

        [System.Xml.Serialization.XmlElement("DbPassword")]
        public string DbPassword
        {
            get
            {
                return _dbPassword;
            }
            set
            {
                _dbPassword = value;
            }
        }

        [System.Xml.Serialization.XmlElement("AddonDbConnection")]
        public string AddonDbConnection
        {
            get
            {
                return _addonDbConnection;
            }
            set
            {
                _addonDbConnection = value;
            }
        }

        [System.Xml.Serialization.XmlElement("AddonDbName")]
        public string AddonDbName
        {
            get
            {
                return _addonDbName;
            }
            set
            {
                _addonDbName = value;
            }
        }

        [System.Xml.Serialization.XmlElement("AddonDbUser")]
        public string AddonDbUser
        {
            get
            {
                return _addonDbUser;
            }
            set
            {
                _addonDbUser = value;
            }
        }

        [System.Xml.Serialization.XmlElement("AddonDbPassword")]
        public string AddonDbPassword
        {
            get
            {
                return _addonDbPassword;
            }
            set
            {
                _addonDbPassword = value;
            }
        }

        [System.Xml.Serialization.XmlElement("WcfConnString")]
        public string WcfConnString
        {
            get
            {
                return _wcfConnString;
            }
            set
            {
                _wcfConnString = value;
            }
        }

        [System.Xml.Serialization.XmlElement("ApSupplier")]
        public string ApSupplier
        {
            get
            {
                return _apSupplier;
            }
            set
            {
                _apSupplier = value;
            }
        }
        #endregion
    }
}
