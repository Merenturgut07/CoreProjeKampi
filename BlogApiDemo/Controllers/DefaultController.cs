using BlogApiDemo.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var c = new Context();
            var values = c.Employes.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult EmployeeAdd(Employe employe)
        {
            using var c = new Context();
            c.Add(employe);
            c.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult EmployeeGet(int id)
        {
            using var c = new Context();
            var employe = c.Employes.Find(id);
            if (employe == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(employe);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult EmployeeDelete(int id)
        {
            using var c = new Context();
            var employee = c.Employes.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(employee);
                c.SaveChanges();
                return Ok();
            }
        }

        [HttpPut]
        public IActionResult EmployeeUpdate(Employe employe)
        {
            using var c = new Context();
            var emp = c.Find<Employe>(employe.ID);
            if (emp == null)
            {
                return NotFound();
            }
            else
            {
                emp.Name = employe.Name;
                c.Update(emp);
                c.SaveChanges();
                return Ok();
            }
        }

    }
}
