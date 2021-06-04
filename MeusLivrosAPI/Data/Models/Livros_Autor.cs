using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeusLivrosAPI.Data.Models
{
    public class Livros_Autor
    {
        public int Id { get; set; }

        public int LivrosId { get; set; }

        public Livros Livros { get; set; }

        public int AutorId { get; set; }

        public Autor Autor { get; set; }
    }
}
