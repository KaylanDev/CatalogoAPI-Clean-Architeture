using Catalogo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Domain.Interfaces
{
    interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetProdutosAsync();
        Task<Categoria> GetByIdAsync(int? id);
        Task<Categoria> CreateAsync(Produto produto);
        Task<Categoria> UpdateAsync(Produto produto);
        Task<Categoria> RemoveAsync(Produto produto);
    }
}
