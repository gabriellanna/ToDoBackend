using ToDo.Domain.Interfaces.Repository;
using ToDo.Domain.Interfaces.Service;
using ToDo.Domain.Models;

namespace ToDo.Service.Service
{
    public class TarefaService : ITarefaService
    {
        private readonly ITarefaRepository _repo;
        public TarefaService(ITarefaRepository repo)
        {
            _repo = repo;
        }
        public async Task<Tarefa> Atualizar(Tarefa tarefa)
        {
            var tarefaDb = await _repo.SelecionarPorIdAsync(tarefa.Id);
            if (tarefaDb == null)
                throw new Exception("Item não encontrado");

            if (tarefa.Nome != null && tarefa.Nome != tarefaDb.Nome)
                tarefaDb.Nome = tarefa.Nome;

            if (tarefa.Descricao != null && tarefa.Descricao != tarefaDb.Descricao)
                tarefaDb.Descricao = tarefa.Descricao;

            if (tarefa.DataDeConclusao != null && tarefa.DataDeConclusao != tarefaDb.DataDeConclusao)
                tarefaDb.DataDeConclusao = tarefa.DataDeConclusao;

            var tarefaAtualizada = await _repo.AtualizarAsync(tarefaDb);

            return tarefaAtualizada;
        }

        public async Task<bool> Deletar(Tarefa tarefa)
        {
            return await _repo.DeletarAsync(tarefa.Id);
        }

        public async Task<Tarefa> Inserir(Tarefa tarefa)
        {
            return await _repo.InserirAsync(tarefa);
        }

        public async Task<IList<Tarefa>> PegarTodas()
        {
            return await _repo.PegarTodas();
        }
    }
}
