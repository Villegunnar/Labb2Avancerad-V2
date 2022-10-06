using Labb2_Avancerad.Models;
using Labb2Avancerad_V2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labb2Avancerad_V2.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : Controller
    {


        private readonly IDepartmentRepository _departmentRepository;


        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        [HttpGet]
        public ActionResult GetAllDepartments()
        {
            try
            {
                return Ok(_departmentRepository.GetAllDepartments.ToList());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult GetDepartmentById(int id)
        {

            try
            {
                var result = _departmentRepository.GetDepartmentById(id);

                if (result == null) return NotFound();

                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult AddDepartment(Department department)
        {
            try
            {
                if (department == null)
                    return BadRequest();

                var result = _departmentRepository.AddDepartment(department);

                return Ok(CreatedAtAction(nameof(GetDepartmentById),
                    new { id = result.DepartmentId }, result));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }
        [HttpPut("{id:int}")]
        public IActionResult UpdateDepartment(int id, Department department)
        {


            try
            {
                if (id != department.DepartmentId)
                    return BadRequest("Employee ID mismatch");

                var result = _departmentRepository.GetDepartmentById(id);

                if (result == null)
                    return NotFound($"Department with Id = {id} not found");

                _departmentRepository.UpdateDepartment(department);

                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating data");
            }

        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteDepartment(int id)
        {
            try
            {
                var result = _departmentRepository.GetDepartmentById(id);

                if (result == null)
                {
                    return NotFound($"Department with Id = {id} not found");
                }
                _departmentRepository.DeleteDepartment(id);


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
