using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabCont.BLL.Interfaces
{
    public interface IUnitOfWork
    {
        public INewsRepository NewsRepository { get; set; }
        Task<int> CompleteAsync();
    }
}
