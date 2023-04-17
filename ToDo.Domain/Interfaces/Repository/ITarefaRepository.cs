using ToDo.Domain.Models;

namespace ToDo.Domain.Interfaces.Repository
{
    public interface ITarefaRepository : IBaseRepository<Tarefa>
    {
         Task<IList<Tarefa>> PegarTodas();
    }
}