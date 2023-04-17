using Microsoft.EntityFrameworkCore;
using ToDo.Domain.Interfaces.Repository;
using ToDo.Domain.Models;
using ToDo.Infra.Context;

namespace ToDo.Infra.Repository
{
    public class TarefaRepository : BaseRepository<Tarefa>, ITarefaRepository
    {
        public TarefaRepository(ToDoContext context) : base(context)
        {
        }

        public async Task<IList<Tarefa>> PegarTodas()
        {
            IList<Tarefa> list;
            try
            {
                list = await _dataSet.ToListAsync();   
            }
            catch (Exception)
            {
                
                throw;
            }
            return list;
        }
    }
}