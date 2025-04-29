using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Application.DTOs
{
  public  class ProdutosDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatorio!")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A descricao é obrigatorio!")]
        [MinLength(10)]
        [MaxLength(150)]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Informe o preco!")]
        [Column(TypeName = "decimal(18,2)")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal Preco { get; set; }
        [MaxLength(250)]
        public string ImagemUrl { get; set; }
        [Required(ErrorMessage = "o estoque é obrigatorio!")]
        [Range(1,9999)]
        public int Estoque { get; set; }
        public DateTime DataCadastro { get; set; }



    }
}
