using ToDo.Domain.Models;

namespace ToDo.Domain.Interfaces.Service
{
    public interface ITarefaService
    {
         public Task<Tarefa> Inserir(Tarefa tarefa);
         public Task<Tarefa> Atualizar(Tarefa tarefa);
         public Task<bool> Deletar(Tarefa tarefa);
         public Task<IList<Tarefa>> PegarTodas();
    }
}