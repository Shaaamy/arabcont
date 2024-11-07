using ArabCont.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabCont.DAL.Contexts
{
    public class ArabContDbContext : DbContext
    {
        public ArabContDbContext(DbContextOptions<ArabContDbContext> options) : base(options)
        {

        }
        public DbSet<News> News{ get; set; }
    }
}
