using Catalogo.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Application.Interfaces
{
  public  interface IProdutoService
    {
        Task<IEnumerable<ProdutosDTO>> GetProdutos();
        Task<ProdutosDTO> GetById(int id);
        Task Add(ProdutosDTO produtosDto);
        Task Update(ProdutosDTO produtosDto);
        Task Remove(int? id);
    }
}
