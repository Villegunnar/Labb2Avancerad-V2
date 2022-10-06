using Labb2_Avancerad.Models;

namespace Labb2Avancerad_V2.Models
{
    public interface IDepartmentRepository 
    {



        //Read
        IEnumerable<Department> GetAllDepartments { get; }

        //Read
        Department GetDepartmentById(int departmentId);

        //Create
        Department AddDepartment(Department department);


        //Update
        Department UpdateDepartment(Department department);

        //Delete
        Department DeleteDepartment(int departmentId);
    }
}
