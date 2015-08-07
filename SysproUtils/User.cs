using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SysproUtils
{
    /// <summary>
    /// LINQ class to reference the SysproAddonsDb table user information.
    /// </summary>
    [Table(Name = "ADM_OperatorInfo")]
    public class User
    {
        private string _networkUserName;
        private string _userPassword;

        [Column(Storage = "_networkUserName", IsPrimaryKey = true)]
        public string NetworkUserName 
        {
            get { return this._networkUserName; }
            set { this._networkUserName = value; }
        }

        [Column(Storage = "_userPassword")]
        public string UserPassword 
        {
            get { return this._userPassword; }
            set { this._userPassword = value; }
        }
    }
}
