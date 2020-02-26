using CircularMVC.Entity;
using CircularMVC.DAL;
using System.Web.Mvc;
using System.Collections.Generic;

namespace CircularMVC.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Home()
        {
            return View();
        }
       
        public ActionResult AddEmployees()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployees(Employee employee)
        {
            if(ModelState.IsValid)
            {
                EmployeeRepository employeeRepository = new EmployeeRepository();
                employeeRepository.CreateEmployeeDB();
                employeeRepository.AddEmployees(employee);
                return RedirectToAction("Login");
            }
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        //public ActionResult EmployeeView()
        //{
        //    IEnumerable<Employee> employeeList=EmployeeRepository.DisplayEmployee();
        //    return PartialView(employeeList);
        //}
    }
}