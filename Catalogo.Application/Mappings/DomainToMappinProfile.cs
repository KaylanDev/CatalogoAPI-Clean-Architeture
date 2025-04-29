using AutoMapper;
using Catalogo.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Domain.Entities;

namespace Catalogo.Application.Mappings
{
    class DomainToMappinProfile : Profile
    {
        public DomainToMappinProfile()
        {
            CreateMap<Categoria, CategoriaDTO>().ReverseMap();
            CreateMap<Produto, ProdutosDTO>().ReverseMap();
        }
    }
}
