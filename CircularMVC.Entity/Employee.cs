using System.ComponentModel.DataAnnotations;
namespace CircularManagementSYstem.Entity
{
    public enum DepartmentList
    {
        Technicalteam=1,
        HRteam,
        Supportteam
    }
    public enum ReportingManager
    {
        CEO=1,
        ProjectManager
    }
    public class Employee
    {
        [Required(ErrorMessage ="Employee name is required")]
        public string employeeName { get; set; }
        public string employeePhoneNumber { get; set; }
        [Required(ErrorMessage = "EMail is required")]
        [Key]
        public string employeeEmail { get; set; }
        protected string employeeId;
        protected string employeePassword;
        protected string departmentName;
        protected string manager_Id;
        public string employeeDesignation { get; set; }
        [Required]
        public string employeeGender { get; set; }
        [Required(ErrorMessage = "Enter employee depy")]
        public DepartmentList department { get; set; }
        [Required(ErrorMessage = "Enter employee man")]
        public ReportingManager manager { get; set; }
        public Employee() { }
        public Employee(string name, string phoneNumber, string email, string password, string manager, string department, string designation)
        {
            employeeName = name;
            employeePhoneNumber = phoneNumber;
            departmentName = department;
            manager_Id = manager;
            employeeDesignation = designation;
            employeeEmail = email;
            employeePassword = password;
        }
    }
    
}
