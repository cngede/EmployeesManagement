using EmployeesManagement.Models;
using Mono.TextTemplating;

namespace EmployeesManagement.Data.Interface
{
    public interface IEmployeeRepository
    {
        public interface IEmployeeRepository
        {


            Task<IEnumerable<Employee>> GetAllEmployees();

            Task<IEnumerable<Employee>> GetSliceAsync(int offset, int size);
            Task<IEnumerable<Employee>> GetEmployeesByEmpNo(string empno);

            Task<IEnumerable<Employee>> GetEmployeesByFirstName(string firstname);
            Task<IEnumerable<Employee>> GetEmployeesByLastName(string lastname);
            Task<IEnumerable<Employee>> GetEmployeesByEmail(string email);
            Task<IEnumerable<Employee>> GetEmployeesByPhone(string phone);
            Task<IEnumerable<Employee>> GetEmployeesByAddress(string address);
            Task<IEnumerable<Employee>> GetEmployeesByDateOfBirth(string dateofbirth);
            Task<IEnumerable<Employee>> GetEmployeesByDepartment(string department);

            bool Add(Employee employee);

            bool Update(Employee employee);

            bool Delete(Employee employee);

            bool Save();
        }
    }

}










