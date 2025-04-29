using Catalogo.Application.DTOs;
using Catalogo.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalogo.Domain.Interfaces;
using AutoMapper;
using Catalogo.Domain.Entities;
namespace Catalogo.Application.Services
{
   public class CategoriaService : ICategoriaService
    {
        private ICategoriaRepository _categoriaRepository;
        private readonly IMapper _mapper;

        public CategoriaService(ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;
        }


        public async Task<IEnumerable<CategoriaDTO>> GetCategorias()
        {
            var categoriaEntities = await _categoriaRepository.GetAsync();
            return _mapper.Map<IEnumerable<CategoriaDTO>>(categoriaEntities);
        }


        public async Task<CategoriaDTO> GetById(int id)
        {
            var categoriaentitie = await _categoriaRepository.GetByIdAsync(id);
            return _mapper.Map<CategoriaDTO>(categoriaentitie);
        }

        public async Task<CategoriaDTO> Add(CategoriaDTO categoriaDTO)
        {

            var categoriaCreat = _mapper.Map<Categoria>(categoriaDTO);
           await _categoriaRepository.CreateAsync(categoriaCreat);
            return _mapper.Map<CategoriaDTO>(categoriaCreat);
            
        }



        public async Task Remove(int? id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            var categoria = await _categoriaRepository.GetByIdAsync(id); // Aguarde a operação
            if (categoria == null) throw new KeyNotFoundException("Categoria não encontrada.");

            await _categoriaRepository.RemoveAsync(categoria); // Aguarde a operação
        }

        public async Task Update(CategoriaDTO categoriaDTO)
        {
            var categoriaUpdate = _mapper.Map<Categoria>(categoriaDTO);
            await _categoriaRepository.UpdateAsync(categoriaUpdate);
        }
    }
}
