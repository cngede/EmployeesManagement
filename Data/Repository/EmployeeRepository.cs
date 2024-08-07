using EmployeesManagement.Data.Interface;
using EmployeesManagement.Models;

namespace EmployeesManagement.Data.Repository
{



    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly ApplicationDbContext _appContext;

        public EmployeeRepository(ApplicationDbContext dataContext)
        {
            _appContext = dataContext;
        }

        public bool AddEmployee(Employee employee)
        {
            if (_appContext.Employees == null)
                return false;

            if (_appContext.Employees.Any(x => x.Id == employee.Id)) { return false; }

            _appContext.Employees.Add(employee);
            _appContext.SaveChanges();
            return true;
        }

        public bool DeleteEmployee(Employee employee)
        {
            if (_appContext.Employees == null)
                return false;

            if (!_appContext.Employees.Any(x => x.Id == employee.Id)) { return false; }

            _appContext.Employees.Remove(employee);
            _appContext.SaveChanges();
            return true;
        }

        public Employee GetEmployeeById(int id)
        {
            if (_appContext.Employees == null)
                return null;

            return _appContext.Employees.FirstOrDefault(x => x.Id == id);
        }

        public IList<Employee> GetEmployees()
        {
            if (_appContext.Employees == null)
                return new List<Employee>();

            return _appContext.Employees.ToList();
        }

        public bool UpdateEmployee(Employee employee)
        {
            if (_appContext.Employees == null)
                return false;

            if (!_appContext.Employees.Any(x => x.Id == employee.Id)) { return false; }

            _appContext.Employees.Update(employee);
            _appContext.SaveChanges();
            return true;
        }
    }
}