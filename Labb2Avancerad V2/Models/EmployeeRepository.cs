using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace Labb2_Avancerad.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }


        // Get All Personal
        public IEnumerable<Employee> GetAllEmployees
        {
            get
            {
                return _context.Employees;

                // För att Returnera Personal med Departments
                // return _context.Personals.Include(p => p.Department);
            }
        }

        // Get Singel Personal
        public Employee GetEmployeeById(int emplyeeId)
        {
            return _context.Employees.FirstOrDefault(x => x.EmployeeId == emplyeeId);
        }
        // Create Personal
        public Employee AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);

            return employee;

        }

        // Delete Personal
        public Employee DeleteEmployee(int employeeId)
        {
            var employeeDelete = _context.Employees.FirstOrDefault(x => x.EmployeeId == employeeId);

            if (employeeDelete != null)
            {
                _context.Employees.Remove(employeeDelete);
                _context.SaveChanges();
                return employeeDelete;
            }

            return null;
        }

        // Update Personal
        public Employee UpdateEmployee(Employee employee)
        {
          

            var employeeUpdate = _context.Employees
               .FirstOrDefault(e => e.EmployeeId == employee.EmployeeId);



            if (employeeUpdate != null)
            {

                employeeUpdate.FirstName = employee.FirstName;
                employeeUpdate.LastName = employee.LastName;
                employeeUpdate.Email = employee.Email;
                employeeUpdate.Gender = employee.Gender;
                employeeUpdate.Adress = employee.Adress;
                employeeUpdate.Salary = employee.Salary;
                employeeUpdate.PhoneNumber = employee.PhoneNumber;
                employeeUpdate.DepartmentId = employee.DepartmentId;

                _context.SaveChanges();
                return employeeUpdate;
            }

            return null;
        }
    }
}
