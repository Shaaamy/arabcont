using ArabCont.BLL.Interfaces;
using ArabCont.DAL.Contexts;
using ArabCont.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabCont.BLL.Repositories
{
    public class NewsRepository : GenericRepository<News>, INewsRepository
    {
        private readonly ArabContDbContext _dbContext;

        public NewsRepository(ArabContDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
