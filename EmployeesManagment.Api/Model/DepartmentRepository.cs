using EmployeeManagement.Models;

namespace EmployeeManagment.Api.Model
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext appDbContext;

        public DepartmentRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public Department GetDepartment(int departmentId)
        {
            var department =  appDbContext.Departments
                            .FirstOrDefault(d => d.DepartmentId == departmentId);
            return department;
        }

        public IEnumerable<Department> GetDepartments()
        {
            return appDbContext.Departments;
        }
    }
}
