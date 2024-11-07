using ArabCont.BLL.Interfaces;
using ArabCont.DAL.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabCont.BLL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ArabContDbContext _dbContext;
        public INewsRepository NewsRepository { get; set; }
        public UnitOfWork(ArabContDbContext dbContext)
        {
            NewsRepository = new NewsRepository(dbContext);
            _dbContext = dbContext;
        }

        public async Task<int> CompleteAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        

    }
}
