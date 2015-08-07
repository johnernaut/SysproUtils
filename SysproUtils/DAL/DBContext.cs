using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysproUtils.DAL
{
    public partial class AddonDbContext : DataContext
    {
        public Table<User> Users;

        public AddonDbContext(string connection) : base(connection) { }
    }
}
