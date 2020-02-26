using System.Data.Entity;
using CircularManagementSYstem.Entity;

namespace CircularManagementSYstem.DAL
{
    class DBUtils:DbContext
    {
        public DBUtils():base("connection")
        {

        }
        public DbSet<Employee> employees { get; set; }
    }
}
