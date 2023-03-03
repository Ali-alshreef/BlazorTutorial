using EmployeeManagment.Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagment.Api.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        { 
            try
            {
                return Ok(await _employeeRepository.GetEmployees());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError , "Error Get Employees");
            }
        }
    }
}
