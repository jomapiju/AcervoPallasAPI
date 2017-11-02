using AcervoPallasAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AcervoPallasAPI.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

    }
}