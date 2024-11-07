using ArabCont.BLL.Interfaces;
using ArabCont.DAL.Contexts;
using ArabCont.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabCont.BLL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ArabContDbContext _dbContext;

        public GenericRepository(ArabContDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(T item)
        {
            await _dbContext.AddAsync(item);
        }

        public void Delete(T item)
        {
            _dbContext.Remove(item);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task GetByIdAsync(int id)
        {
            await _dbContext.Set<T>().FindAsync(id);
        }

        public void Update(T item)
        {
            _dbContext.Update(item);
        }
    }
}
