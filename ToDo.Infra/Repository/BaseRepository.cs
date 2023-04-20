using Microsoft.EntityFrameworkCore;
using ToDo.Domain.Interfaces.Repository;
using ToDo.Domain.Models;
using ToDo.Infra.Context;

namespace ToDo.Infra.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly ToDoContext _context;
        protected DbSet<T> _dataSet;
        public BaseRepository(ToDoContext context)
        {
            _context = context;
            _dataSet = _context.Set<T>();
        }
        public async Task<T> AtualizarAsync(T item)
        {
            try
            {
                var result = await _dataSet.SingleOrDefaultAsync(entity => entity.Id.Equals(item.Id));

                _context.Entry(result).CurrentValues.SetValues(item);

                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
            return item;
        }

        public async Task<bool> DeletarAsync(int id)
        {
            try
            {
                var result = await _dataSet.SingleOrDefaultAsync(entity => entity.Id.Equals(id));
                
                _dataSet.Remove(result);

                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }

            return true;
        }

        public async Task<T> InserirAsync(T item)
        {
            try
            {
                _dataSet.Add(item);

                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }

            return item;
        }

        public async Task<T> SelecionarPorIdAsync(int id)
        {           
            try
            {
                return await _dataSet.SingleOrDefaultAsync(entity => entity.Id.Equals(id));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}