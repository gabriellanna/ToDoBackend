using ToDo.Domain.Interfaces.Repository;
using ToDo.Domain.Interfaces.Service;
using ToDo.Domain.Models;

namespace ToDo.Service.Service
{
    public class TarefaService : ITarefaService
    {
        private readonly ITarefaService _repo;
        public TarefaService(ITarefaService repo)
        {
            _repo = repo;
        }
        public Task<Tarefa> Atualizar(Tarefa tarefa, int id)
        {
            throw new NotImplementedException();
        }

        public Task<Tarefa> Deletar(Tarefa tarefa, int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Tarefa> Inserir(Tarefa tarefa)
        {
            return await _repo.Inserir(tarefa);
        }

        public async Task<Tarefa> PegarTodas()
        {
            return await _repo.PegarTodas();
        }
    }
}