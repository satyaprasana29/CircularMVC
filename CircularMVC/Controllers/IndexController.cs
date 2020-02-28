using CircularManagementSYstem.Entity;
using CircularManagementSYstem.DAL;
using System.Web.Mvc;
namespace CircularManagementSYstem.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        [HandleError]
        public ActionResult Home()
        {
            return View();
        }
       
        public ActionResult AddEmployees()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
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
        //public ActionResult ErrorAction()
        //{
        //    return View();
        //}
    }
}