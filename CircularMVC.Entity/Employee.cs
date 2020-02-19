namespace CircularMVC.Entity
{
    public enum DepartmentList
    {
        Technicalteam,
        HRteam,
        Supportteam
    }
    public enum ReportingManager
    {
        CEO,
        ProjectManager
    }
    public class Employee
    {
        protected string employeeName;
        protected string employeePhoneNumber;
        protected string employeeEmail;
        protected string employeeId;
        protected string employeePassword;
        protected int department_id;
        protected int manager_id;
        protected string employeeDesignation;
        public string employeeGender { get; set; }
        public DepartmentList department { get; set; }
        public ReportingManager manager { get; set; }
        public Employee() { }
        public Employee(string name, string phoneNumber, string email, string password, int manager_id, int department_id, string designation)
        {
            employeeName = name;
            employeePhoneNumber = phoneNumber;
            this.department_id = department_id;
            this.manager_id = manager_id;
            employeeDesignation = designation;
            employeeEmail = email;
            employeePassword = password;
        }
    }
    
}
