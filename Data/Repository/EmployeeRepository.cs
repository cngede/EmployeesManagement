using EmployeesManagement.Data.Interface;
using EmployeesManagement.Models;

namespace EmployeesManagement.Data.Repository
{



    public class EmployeeRepository : IEmployeeRepository
    {

        public ApplicationDbContext AppContext { get; }

        public EmployeeRepository(ApplicationDbContext dataContext)
        {
            AppContext = dataContext;
        }

        public bool AddEmployee(Employee employee)
        {
            if (AppContext.Employees == null)
                return false;

            if (AppContext.Employees.Any(x => x.Id == employee.Id)) { return false; }

            AppContext.Employees.Add(employee);
            Save();
            return true;
        }

        public bool DeleteEmployee(Employee employee)
        {
            if (AppContext.Employees == null)
                return false;

            if (!AppContext.Employees.Any(x => x.Id == employee.Id)) { return false; }

            AppContext.Employees.Remove(employee);
            AppContext.SaveChanges();
            return true;
        }

        public async Task <Employee?> GetEmployeesByEmpNo(string? EmpNo)
        {
            if (AppContext.Employees == null)
                return null;

            return AppContext.Employees.FirstOrDefault(x => x.EmpNo == EmpNo);
        }

        public async Task<Employee?> GetEmployeesByAddress(string Address)
        {
            if (AppContext.Employees == null)
                return null;

            return AppContext.Employees.FirstOrDefault(x => x.Address == Address);
        }

        public async Task<Employee?> GetEmployeesByDateOfBirth(DateTime DateOfBirth)
        {
            if (AppContext.Employees == null)
                return null;

            return AppContext.Employees.FirstOrDefault(x => x.DateOfBirth == DateOfBirth);
        }


        public async Task<Employee?> GetEmployeesByDepartment(string Department)
        {
            if (AppContext.Employees == null)
                return null;

            return AppContext.Employees.FirstOrDefault(x => x.Department == Department);
        }


        public async Task<Employee?> GetEmployeesByEmail(string Email)
        {
            if (AppContext.Employees == null)
                return null;

            return AppContext.Employees.FirstOrDefault(x => x.Email == Email);
        }


        public async Task<Employee?> GetEmployeesByFirstName(string FirstName)
        {
            if (AppContext.Employees == null)
                return null;

            return AppContext.Employees.FirstOrDefault(x => x.FirstName == FirstName);
        }


        public async Task<Employee?> GetEmployeesByLastName(string LastName)
        {
            if (AppContext.Employees == null)
                return null;

            return AppContext.Employees.FirstOrDefault(x => x.LastName == LastName);
        }


        public async Task<Employee?> GetEmployeesByPhone(string Phone)
        {
            if (AppContext.Employees == null)
                return null;

            return AppContext.Employees.FirstOrDefault(x => x.Phone == Phone);
        }


        public void Save()
        {
            AppContext.SaveChanges();
        }


        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            if (AppContext.Employees == null)
                return new List<Employee>();

            return AppContext.Employees.ToList();
        }

        public bool UpdateEmployee(Employee employee)
        {
            if (AppContext.Employees == null)
                return false;

            if (!AppContext.Employees.Any(x => x.Id == employee.Id)) { return false; }

            AppContext.Employees.Update(employee);
            AppContext.SaveChanges();
            return true;
        }
    }
}
