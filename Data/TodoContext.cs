using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Data
{
    public class TodoContext:DbContext
    {
       public TodoContext(dbcontextOptions<TodoContext> options)
            :base(options)
            {

            }
            public DbSet<TodoItem> TodoItems {get; set;}     
    }
}