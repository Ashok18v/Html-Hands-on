using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Employee.Api;

namespace Employee.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeApiContext _context;

        public EmployeesController(EmployeeApiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employees>> Get()
        {
            return Ok(_context.employeesList);
        }
        [HttpPost]
        public async Task<ActionResult<Employees>> Post(Employees emp)
        {
            _context.employeesList.Add(emp);
            return Ok(_context.employeesList);
        }
        [HttpPut ("{id}")]
        public  ActionResult Put(Employees emp,int id)
        {
            var result = _context.employeesList.Where(e => e.Id == id).FirstOrDefault();
           _context.employeesList.Remove(result);
            result.First_Name = emp.First_Name;
            result.Last_Name = emp.Last_Name;
            result.Mobile_Number=emp.Mobile_Number;
            result.Email = emp.Email;
            result.Address = emp.Address;
            _context.employeesList.Add(result);
            return Ok(_context.employeesList);
        }

        [HttpDelete("{id}")]
      public ActionResult Delete(int id)
        {
            var emp=_context.employeesList.Where(x => x.Id==id).FirstOrDefault();
            _context.employeesList.Remove(emp);
            return Ok(_context.employeesList);
        }
        [HttpGet("{search}")]
        public  ActionResult Seaching(string search)
        {
            if (search == null)
            {
                return BadRequest();
            }
            if (_context.employeesList == null)
            {
                return NotFound();
            }
          var emp =  _context.employeesList.Where(e => e.Email.Contains(search) || e.First_Name.Contains(search) || e.Last_Name.Contains(search) ||e.Address.Contains(search)).ToList();
            
            if (emp == null)
            {
                return  NotFound("Record doesn't exists");
            }

            return Ok(emp);
           

        }
    }
}
