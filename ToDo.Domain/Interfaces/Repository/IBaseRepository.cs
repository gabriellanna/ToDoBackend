using ToDo.Domain.Models;

namespace ToDo.Domain.Interfaces.Repository
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
         Task<T> InserirAsync(T item);
         Task<T> AtualizarAsync(T item);
         Task<bool> DeletarAsync(int id);
    }
}