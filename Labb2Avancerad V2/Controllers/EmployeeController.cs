using Labb2_Avancerad.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Labb2_Avancerad.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [HttpGet]
        public ActionResult GetAllEmployees()
        {
            try
            {
                return Ok(_employeeRepository.GetAllEmployees.ToList());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult GetEmployeeById(int id)
        {

            try
            {
                var result = _employeeRepository.GetEmployeeById(id);

                if (result == null) return NotFound();

                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            try
            {
                if (employee == null)
                    return BadRequest();

                var result = _employeeRepository.AddEmployee(employee);
                

                return Ok(CreatedAtAction(nameof(GetEmployeeById),
                    new { id = result.EmployeeId }, result));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }
        [HttpPut("{id:int}")]
        public IActionResult UpdateEmployee(int id, Employee employee)
        {


            try
            {
                if (id != employee.EmployeeId)
                    return BadRequest("Employee ID mismatch");

                var result = _employeeRepository.GetEmployeeById(id);

                if (result == null)
                    return NotFound($"Employee with Id = {id} not found");

                _employeeRepository.UpdateEmployee(employee);

                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }

        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteEmployee(int id)
        {
            try
            {
                var result = _employeeRepository.GetEmployeeById(id);

                if (result == null)
                {
                    return NotFound($"Employee with Id = {id} not found");
                }
                _employeeRepository.DeleteEmployee(id);


                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
               "Error deleting data");
            }

        }
    }
}
