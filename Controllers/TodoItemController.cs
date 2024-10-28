using Microsoft.AspNetCore.Mvc;
using projectapitest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;.
using System.Threading.Tasks;

namespace projectapitest.Controllers
{
  
    [ApiController]
    [Route("[controller]")]
    public class TodoItemController
    {
        private TodoContext _studentContext;

         

        public TodoItemController(TodoContext context)
        {
            _studentContext = context;
        }

        [HttpGet(Name = "GetTodoItem")]
        public IEnumerable<TodoItem> Get()
        {
            return _studentContext.TodoItems.ToList();
        }

        [HttpGet]
        [Route("getbyid/{id}")]
        public ActionResult<TodoItem> GetById(int id)
        {
            if (id <= 0)
            {
                return NotFound("Student id must be higher than zero");
            }
            TodoItem student = _studentContext.TodoItems.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound("Student not found");
            }
            return Ok(student);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTodoItem([FromBody] TodoItem todoItem)
        {
            try
            {
                if (todoItem == null)
                    return BadRequest();

                var createdEmployee = await TodoIt employeeRepository.AddEmployee(todoItem);

                return CreatedAtAction(nameof(GetEmployee),
                    new { id = createdEmployee.EmployeeId }, createdEmployee);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new employee record");
            }
        }

    }
}
