using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<string> employees = new List<string>
        {
            "Ankit",
            "Saloni",
            "Rahul"
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id < 0 || id >= employees.Count)
                return NotFound();

            return Ok(employees[id]);
        }

        [HttpPost]
        public IActionResult Post([FromBody] string employee)
        {
            employees.Add(employee);
            return Ok("Employee Added Successfully");
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string employee)
        {
            if (id < 0 || id >= employees.Count)
                return BadRequest();

            employees[id] = employee;
            return Ok("Employee Updated Successfully");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= employees.Count)
                return BadRequest();

            employees.RemoveAt(id);
            return Ok("Employee Deleted Successfully");
        }
    }
}