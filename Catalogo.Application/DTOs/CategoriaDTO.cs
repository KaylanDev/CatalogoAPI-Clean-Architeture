using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Application.DTOs
{
    class CategoriaDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "name is required!")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Nome { get; private set; }
        [Required(ErrorMessage = "Image is required!")]
        [MinLength(3)]
        [MaxLength(500)]
        public string ImagemUrl { get; private set; }

    }
}
