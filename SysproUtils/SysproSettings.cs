using System;

namespace SysproUtils
{
    /// <summary>
    /// Settings loaded from returned operator Syspro XML.
    /// </summary>
    [Serializable()]
    public class SysproSettings
    {
        public string Operator { get; set; }
        public string OperatorName { get; set; }
        public string NetworkUserName { get; set; }
        public string Company { get; set; }
        public string CompanyName { get; set; }
        public string DataSourceName { get; set; }
        public string CompanyDatabaseName { get; set; }
    }
}
