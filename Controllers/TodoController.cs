using System.Collections.Generic;
using System.Linq;
using AcervoPallasAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcervoPallasAPI.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private readonly TodoContext _context;
        public TodoController(TodoContext context)
        {
            _context = context;
            
            if(_context.TodoItems.Count() == 0)
            {
                _context.TodoItems.Add(new TodoItem {Nome = "José"});
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<TodoItem> GetAlll()
        {
            return _context.TodoItems.ToList();
        }

        
    }
}