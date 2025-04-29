using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Domain.Entities
{
   public class Categoria : Entity
    {
        public string Nome { get;private set; }
        public string ImagemUrl { get;private set; }
        ICollection<Produto> Produtos { get; set; }

        public Categoria(int id,string nome, string imagemUrl)
        {
            Id = id;
            Nome = nome;
            ImagemUrl = imagemUrl;
            
        }
    }
}
