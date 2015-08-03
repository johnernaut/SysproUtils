using System;
using Encore;

namespace SysproUtils
{
    class EncoreClient : IActionable
    {
        #region Private Properties
        private Utilities encoreClient;
        private Instance encoreInstance;
        private LogDetail encoreLogDetail;
        private Language encoreLang;
        #endregion

        public EncoreClient()
        {
            encoreClient = new Utilities();
            encoreInstance = new Instance();
            encoreLogDetail = new LogDetail();
            encoreLang = new Language();
        }

        public string Logon(string OperatorName, string Password, string CompanyId, string CompanyPassword)
        {
            string GUID;

            try
            {
                GUID = encoreClient.Logon(OperatorName, Password,
                    CompanyId, CompanyPassword, encoreLang, encoreLogDetail, encoreInstance, "");
            }
            catch (Exception ex)
            {
                Logger.Log("Error logging in: " + ex.Message);
                throw ex;
            }

            return GUID;
        }

        public string Post(string UserId, string BusinessObject, string XmlParameters, string XmlIn)
        {
            throw new NotImplementedException();
        }
    }
}
