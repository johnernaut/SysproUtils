using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SYSPROWCFServicesClientLibrary40;

namespace SysproUtils
{
    class WCFClient : IActionable
    {
        #region Private Properties
        private SYSPROWCFServicesPrimitiveClient wcfClient;
        #endregion

        public WCFClient(string host)
        {
            wcfClient = new SYSPROWCFServicesPrimitiveClient(
                host, SYSPROWCFBinding.NetTcp);
        }

        /// <summary>
        /// Return the operator GUID from Syspro using WCF Services.
        /// </summary>
        /// <param name="OperatorName">Username of the operator</param>
        /// <param name="Password">Operator password</param>
        /// <param name="CompanyId">Operator company ID</param>
        /// <param name="CompanyPassword">Company password</param>
        /// <returns></returns>
        public string Logon(string OperatorName, string Password, string CompanyId, string CompanyPassword)
        {
            string GUID;

            try
            {
                GUID = wcfClient.Logon(OperatorName, Password, 
                    CompanyId, CompanyPassword);
            }
            catch (Exception ex)
            {
                Logger.Log("Error logging in to WCF: " + ex.Message);
                throw ex;
            }

            return GUID;
        }

        public void Logoff(string GUID)
        {
            try
            {
                GUID = wcfClient.Logoff(GUID);
            }
            catch (Exception ex)
            {
                Logger.Log("Error logging in to WCF: " + ex.Message);
                throw ex;
            }
        }

        /// <summary>
        /// Post data to Syspro business object.
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="BusinessObject"></param>
        /// <param name="XmlParameters"></param>
        /// <param name="XmlIn"></param>
        /// <returns></returns>
        public string Post(string UserId, string BusinessObject, string XmlParameters, string XmlIn)
        {
            var result = wcfClient.TransactionPost(UserId, BusinessObject, XmlParameters, XmlIn);

            return result;
        }
    }
}
