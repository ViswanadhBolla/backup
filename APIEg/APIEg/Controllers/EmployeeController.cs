using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using APIEg.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIEg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EurofinsDBContext db;
        public EmployeeController(EurofinsDBContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> getEmployee()
        {
            return Ok(await db.Employees.ToListAsync());
        }

        [HttpGet]
        [Route("getEmpById{id}")]
        public async Task<ActionResult>getEmployeeByID(int id)
        {
            if(id == null)
            {
                return BadRequest();
            }
            Employee employee = await db.Employees.FindAsync(id);
            return Ok(employee);
        }
        [HttpPost]
        public async Task<ActionResult> AddEmployee([FromBody] Employee E)
        {
            if(E == null)
            {
                return BadRequest();
            }
            if(ModelState.IsValid)
            {
                db.Employees.Add(E);
                await db.SaveChangesAsync();
            }
            else
            {
                return NotFound();
            }
            return Ok();
        }
        [HttpPut]
        public async Task<ActionResult> EditEmployee(int id, [FromBody]Employee e)
        {
            db.Employees.Update(e);
            await db.SaveChangesAsync();
            return Ok(e);
        }
        [HttpDelete]
        public async Task<ActionResult> DeleteEmployee(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var employee = await db.Employees.FindAsync(id);
                db.Remove(employee);
                db.SaveChanges();
            }
            return Ok();

        }
        
    }

    
}
