using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeusLivrosAPI.Data.Models
{
    public class Publicar
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        //Navegação Propriedades
        public List<Livros> Livros { get; set; }
    }
}
