using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysproUtils
{
    #region UserInfo Struct
    struct UserInfo
    {
        public string GUID;
    }
    #endregion

    #region SysproTypes
    /// <summary>
    /// Syspro connection types to use when creating a service object.
    /// </summary>
    public enum SysproTypes
    {
        /// <summary>
        /// WCF Service reference.
        /// </summary>
        WcfService,
        /// <summary>
        /// COM object reference.
        /// </summary>
        COM,
        /// <summary>
        /// Web services reference.
        /// </summary>
        WebService
    }
    #endregion

    #region BusinessObject Definitions
    /// <summary>
    /// Business objects to use when querying Syspro.
    /// </summary>
    public static class BO
    {
        /// <summary>
        /// Accounts payable.
        /// </summary>
        public static string APSTIN = "APSTIN";
    }
    #endregion

    #region Common Interface Definition
    interface IActionable
    {
        // Shared Syspro Logon function
        string Logon(string OperatorName, string Password,
            string CompanyId, string CompanyPassword);

        // Post XML to business object
        string Post(string UserId, string BusinessObject,
            string XmlParameters, string XmlIn);

        void Logoff(string GUID);
    }
    #endregion

}
