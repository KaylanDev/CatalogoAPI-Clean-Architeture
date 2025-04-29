using Catalogo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Domain.Interfaces
{
  public  interface IRepository <T> 
    {
        Task<IEnumerable<T>> GetAsync();
        Task<T> GetByIdAsync(int? id);
        Task<T> CreateAsync(T t);
        Task<T> UpdateAsync(T t);
        Task<T> RemoveAsync(T t);
    }
}
