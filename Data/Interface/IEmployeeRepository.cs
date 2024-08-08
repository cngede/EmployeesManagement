using EmployeesManagement.Models;
using Mono.TextTemplating;

namespace EmployeesManagement.Data.Interface
{
    public interface IEmployeeRepository
    {
           // ApplicationDbContext AppContext { get; }

             ICollection<Employee> Employees();

            Task<IEnumerable<Employee>> GetAllEmployees();

            
            Task<Employee?> GetEmployeesByEmpNo(string empno);

            Task<Employee?> GetEmployeesByFirstName(string firstname);
            Task<Employee?> GetEmployeesByLastName(string lastname);
            Task<Employee?> GetEmployeesByEmail(string email);
            Task<Employee?> GetEmployeesByPhone(string phone);
            Task<Employee?> GetEmployeesByAddress(string address);
            Task<Employee?> GetEmployeesByDateOfBirth(DateTime dateOfBirth);
            Task<Employee?> GetEmployeesByDepartment(string department);

            bool AddEmployee(Employee employee);
            bool CreateEmployee(Employee employee);

            bool UpdateEmployee(Employee employee);

            bool DeleteEmployee(Employee employee);

            void Save();
    }

}










