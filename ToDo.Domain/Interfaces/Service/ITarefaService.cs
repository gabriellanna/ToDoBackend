using ToDo.Domain.Models;

namespace ToDo.Domain.Interfaces.Service
{
    public interface ITarefaService
    {
         public Task<Tarefa> Inserir(Tarefa tarefa);
         public Task<Tarefa> Atualizar(Tarefa tarefa, int id);
         public Task<Tarefa> Deletar(Tarefa tarefa, int id);
         public Task<Tarefa> PegarTodas();
    }
}