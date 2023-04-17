using Microsoft.EntityFrameworkCore;
using ToDo.Domain.Models;

namespace ToDo.Infra.Context
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {            
        }
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}