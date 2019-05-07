using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngCore.API.Data;
using AngCore.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly DataContext _context;
        public TodosController(DataContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetTodos()
        {
            ///TODO use try catch
            var todos = await _context.Todos.ToListAsync();
            ///TODO use DTO and Mapper
            ///TODO use Services or Repository to Usher Data from Entities
            return Ok(todos);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTodo(int id)
        {
            var todo = await _context.Todos.FirstOrDefaultAsync(x => x.Id == id);
            if (todo == null)
            {
                return NotFound();
            }
            return Ok(todo);
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<Todo>> PostTodoItem(Todo todo)
        {
              _context.Todos.Add(todo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTodo), new { id = todo.Id }, todo);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
       public async Task<IActionResult> PutTodoItem(long id, Todo item)
        {
                if (id != item.Id)
                {
                    return BadRequest();
                }

                _context.Entry(item).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(int id)
        {
            var todoItem = await _context.Todos.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            _context.Todos.Remove(todoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
