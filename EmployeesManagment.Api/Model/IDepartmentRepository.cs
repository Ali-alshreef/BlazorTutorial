using EmployeeManagement.Models;

namespace EmployeeManagment.Api.Model
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
        Department GetDepartment(int departmentId);
    }
}
