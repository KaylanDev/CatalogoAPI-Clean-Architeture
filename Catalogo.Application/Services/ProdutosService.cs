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

namespace Catalogo.Application.Services
{
    class ProdutosService : IProdutoService
    {
        private IProdutoService _produtoService;
        private readonly IMapper _mapper;

        public ProdutosService(IProdutoService produtoService, IMapper mapper)
        {
            _produtoService = produtoService;
            _mapper = mapper;
        }
        public Task<IEnumerable<ProdutosDTO>> GetProdutos()
        {
           
        }
        public Task<ProdutosDTO> GetById(int id)
        {
           
        }


        public Task Add(ProdutosDTO produtosDto)
        {
           
        }



        public Task Remove(int? id)
        {
           
        }

        public Task Update(ProdutosDTO produtosDto)
        {
           
        }
    }
}
