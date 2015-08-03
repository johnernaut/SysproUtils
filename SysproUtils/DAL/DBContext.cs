using System.Data.Linq;

namespace SysproUtils.DAL
{
    public partial class AddonDbContext : DataContext
    {
        public Table<User> Users;

        public AddonDbContext(string connection) : base(connection) { }
    }
}
