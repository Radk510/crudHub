using System.Collections.Generic;
using CrudHub.WebApi.Models;
using CrudHub.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CrudHub.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeAPIController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeAPIController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // Get:         /api/employeeApi
        [HttpGet]
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeService.GetEmployees();
        }

        // Get: /api/employeeApi/id
        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployeeItem([FromRoute]int id)
        {
            var employeeItem = _employeeService.GetEmployee(id);

            if (employeeItem == null)
            {
                return NotFound();
            }

            return employeeItem;
        }

        // Post:            api/employeeApi
        [HttpPost]
        public ActionResult<Employee> PostEmployeeItem([FromBody]Employee model)
        {
            _employeeService.PostEmployee(model);

            return CreatedAtAction("GetEmployeeItem", new { Id = model.EmployeeId }, model);
        }

        // Put:         /api/employeeApi/id
        [HttpPut("{id}")]
        public ActionResult PutEmployeeItem([FromRoute]int id, [FromBody]Employee model)
        {
            if (id != model.EmployeeId)
            {
                return BadRequest();
            }
            _employeeService.EditEmployee(id, model);

            return NoContent();
        }

        // Delete:          /api/employeeapi/id
        [HttpDelete("{id}")]
        public ActionResult<Employee> DeleteEmployeeItem([FromRoute]int id)
        {
            var employeeItem = _employeeService.GetEmployee(id);

            if (employeeItem == null)
            {
                return NotFound();
            }
            _employeeService.DeleteEmployee(employeeItem);

            return employeeItem;
        }
    }
}