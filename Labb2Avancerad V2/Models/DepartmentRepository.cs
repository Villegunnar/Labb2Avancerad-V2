using Labb2_Avancerad.Models;

namespace Labb2Avancerad_V2.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {

        private readonly AppDbContext _context;

        public DepartmentRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Department> GetAllDepartments
        {
            get
            {
                return _context.Departments;
            }
        }
        public Department GetDepartmentById(int departmentId)
        {
            return _context.Departments.FirstOrDefault(x => x.DepartmentId == departmentId);
        }

        public Department AddDepartment(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();

            return department;
        }

        public Department DeleteDepartment(int departmentId)
        {
            var departmentDelete = _context.Departments.FirstOrDefault(x => x.DepartmentId == departmentId);

            if (departmentDelete != null)
            {
                _context.Departments.Remove(departmentDelete);
                _context.SaveChanges();
                return departmentDelete;
            }

            return null;
        }



        public Department UpdateDepartment(Department department)
        {

            var departmentUpdate = _context.Departments
               .FirstOrDefault(e => e.DepartmentId == department.DepartmentId);



            if (departmentUpdate != null)
            {

                departmentUpdate.DepartmentName = department.DepartmentName;



                _context.SaveChanges();
                return departmentUpdate;
            }

            return null;
        }
    }


}
