using Microsoft.AspNetCore.Mvc;
using RollOffWebAPI.Models;
using RollOffWebAPI.Repository;
using RollOffWebAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RollOffWebAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private IEmployee _employeeService;
        public EmployeeController(IEmployee employeerepo)
        {
            _employeeService = employeerepo;
        }
        [HttpGet]
       public List<EmployeeDatum> GetAllDetails()
        {
            return _employeeService.GetAllDetails();
        }
        [HttpGet("ById")]
        public IActionResult GetEmployeeById(double id)
        {
            var emp = _employeeService.GetID(id);
            if (emp == null)
            {
                return NotFound();
            }
            return Ok(emp);      
        }
        [HttpGet("ByEmail")]
        public IActionResult GetEmployeeByEmail(string email)
        {
            var emp = _employeeService.GetEmail(email);
            if (emp == null)
            {
                return NotFound();
            }
            return Ok(emp);
        }
        [HttpGet("ByName")]
        public IActionResult GetEmployeeByName(string name)
        {
            var emp = _employeeService.GetName(name);
            if (emp == null)
            {
                return NotFound();
            }
            return Ok(emp);
        }
    }
}
