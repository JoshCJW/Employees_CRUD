using EmployeesAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EmployeesAPI.Models;

namespace EmployeesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private readonly EmployeesDBContext _employeesDBContext;
        public EmployeesController(EmployeesDBContext employeesDBContext)
        {
            _employeesDBContext = employeesDBContext;

        }

        //Async method, return all employees
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _employeesDBContext.Employees.ToListAsync();
      
            return Ok(employees); 
        }

        //Async method, Add employee

        [HttpPost]
        public async Task<IActionResult> AddEmployee([FromBody] Employee employeeRequest)
        {
            // Auto create new id for employee
            employeeRequest.Id = Guid.NewGuid();

            await _employeesDBContext.Employees.AddAsync(employeeRequest);
            await _employeesDBContext.SaveChangesAsync();

            return Ok(employeeRequest);
        }

        //Async method, Get employee

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult>GetEmployee([FromRoute] Guid id)
        {
          var employee = await _employeesDBContext.Employees.FirstOrDefaultAsync(x => x.Id == id);

          if (employee == null)
            {
                return NotFound();
            }
          return Ok(employee);
        }

        //Async method, Update employee

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> UpdateEmployee([FromRoute] Guid id, Employee updateEmployeeRequest)
        {
          var employee = await _employeesDBContext.Employees.FindAsync(id);
          if (employee == null)
          {
            return NotFound();
          }
          
          employee.name = updateEmployeeRequest.name;
          employee.email = updateEmployeeRequest.email;
          employee.phone = updateEmployeeRequest.phone;
          employee.salary = updateEmployeeRequest.salary;
          employee.department = updateEmployeeRequest.department;

          await _employeesDBContext.SaveChangesAsync();

          return Ok(employee);

        }

        //Async method, Delete employee
        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> DeleteEmployee([FromRoute] Guid id)
        {

            var employee = await _employeesDBContext.Employees.FindAsync(id);
            
            if(employee == null)
            {
                return NotFound();
            }
            _employeesDBContext.Employees.Remove(employee);
            await _employeesDBContext.SaveChangesAsync();

            return Ok(employee);
        }



    }
}
