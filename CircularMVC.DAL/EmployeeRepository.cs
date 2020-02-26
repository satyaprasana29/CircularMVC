using System.Collections.Generic;
using CircularManagementSYstem.Entity;
using System.Linq;
namespace CircularManagementSYstem.DAL
{
    public class EmployeeRepository
    {
        
        public IEnumerable<Employee> CreateEmployeeDB()
        {
            DBUtils dBUtils = new DBUtils();
            return dBUtils.employees.ToList();
        }
        public void AddEmployees(Employee employee)
        {
            DBUtils dBUtils = new DBUtils();
            dBUtils.employees.Add(employee);
            dBUtils.SaveChanges();
        }
    }
}