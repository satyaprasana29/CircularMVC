using System.Collections.Generic;
using CircularMVC.Entity;
using System.Linq;
namespace CircularMVC.DAL
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