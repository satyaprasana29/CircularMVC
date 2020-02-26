using System.Data.Entity;
using CircularMVC.Entity;

namespace CircularMVC.DAL
{
    class DBUtils:DbContext
    {
        public DBUtils():base("connection")
        {

        }
        public DbSet<Employee> employees { get; set; }
    }
}
