namespace Labb2_Avancerad.Models
{
    public interface IEmployeeRepository 
    {


        //Read
        IEnumerable<Employee> GetAllEmployees { get; }

        //Read
        Employee GetEmployeeById(int EmployeeId);

        //Create
        Employee AddEmployee(Employee employee);


        //Update
        Employee UpdateEmployee(Employee employee);

        //Delete
        Employee DeleteEmployee(int employeeId);


    }
}
