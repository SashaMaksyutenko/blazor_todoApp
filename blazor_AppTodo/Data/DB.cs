using Microsoft.EntityFrameworkCore;
using blazor_todo_app.Models;
using System.Threading.Tasks;
namespace blazor_todo_app.Data
{
    public class DB:DbContext
	{
        public DB(DbContextOptions<DB> options): base(options) { }
        public DbSet<TodoItem> TodoItems { get; set; }
	}
}

