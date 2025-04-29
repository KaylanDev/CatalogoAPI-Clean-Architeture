using Catalogo.Application.DTOs;
using Catalogo.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Domain.Entities;
using Catalogo.Domain.Interfaces;
using AutoMapper;
using System.Runtime.CompilerServices;


namespace Catalogo.Application.Services
{
  public class ProdutoService : IProdutoService
    {
        private IProdutoRepository _produtoService;
        private readonly IMapper _mapper;

        public ProdutoService(IProdutoRepository produtoService, IMapper mapper)
        {
            _produtoService = produtoService;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ProdutosDTO>> GetProdutos()
        {
           var produtosEntities = await _produtoService.GetAsync();
            return _mapper.Map<IEnumerable<ProdutosDTO>>(produtosEntities);
        }
        public async Task<ProdutosDTO> GetById(int id)
        {
           var produtosEntities = await _produtoService.GetByIdAsync(id);
            return _mapper.Map<ProdutosDTO>(produtosEntities);
        }


        public async Task Add(ProdutosDTO produtosDto)
        {
           var produtosCreate = _mapper.Map<Produto>(produtosDto);
            await _produtoService.CreateAsync(produtosCreate);
          
        }



        public async Task Remove(int? id)
        {
           var produtosRemove = _mapper.Map<Produto>(_produtoService.GetByIdAsync(id));
            await _produtoService.RemoveAsync(produtosRemove);
        }

        public async Task Update(ProdutosDTO produtosDto)
        {
            var produtosUpdate = _mapper.Map<Produto>(produtosDto);
              await _produtoService.UpdateAsync(produtosUpdate);
        }
    }
}
