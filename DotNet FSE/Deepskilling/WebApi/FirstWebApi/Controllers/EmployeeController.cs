using FirstWebApi.Filters;
using FirstWebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        private List<Employee> employees;

        public EmployeeController()
        {
            employees = GetStandardEmployeeList();
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Ankit",
                    Salary = 50000,
                    Permanent = true,
                    DateOfBirth = new DateTime(2002, 5, 20),
                    Department = new Department
                    {
                        Id = 101,
                        Name = "IT"
                    },
                    Skills = new List<Skill>
                    {
                        new Skill
                        {
                            Id = 1,
                            Name = "C#"
                        },
                        new Skill
                        {
                            Id = 2,
                            Name = "SQL"
                        }
                    }
                },

                new Employee
                {
                    Id = 2,
                    Name = "Saloni",
                    Salary = 60000,
                    Permanent = true,
                    DateOfBirth = new DateTime(2003, 3, 15),
                    Department = new Department
                    {
                        Id = 102,
                        Name = "HR"
                    },
                    Skills = new List<Skill>
                    {
                        new Skill
                        {
                            Id = 3,
                            Name = "Communication"
                        },
                        new Skill
                        {
                            Id = 4,
                            Name = "Management"
                        }
                    }
                }
            };
        }

        [AllowAnonymous]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Employee>> GetStandard()
        {
            return Ok(employees);
        }

        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee employee)
        {
            employees.Add(employee);
            return Ok(employee);
        }

        [HttpPut]
        public ActionResult<Employee> Put([FromBody] Employee employee)
        {
            if (employee.Id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            Employee existingEmployee = employees.FirstOrDefault(e => e.Id == employee.Id);

            if (existingEmployee == null)
            {
                return BadRequest("Invalid employee id");
            }

            existingEmployee.Name = employee.Name;
            existingEmployee.Salary = employee.Salary;
            existingEmployee.Permanent = employee.Permanent;
            existingEmployee.Department = employee.Department;
            existingEmployee.Skills = employee.Skills;
            existingEmployee.DateOfBirth = employee.DateOfBirth;

            return Ok(existingEmployee);
        }
    }
}