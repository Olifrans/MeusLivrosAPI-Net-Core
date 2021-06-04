using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeusLivrosAPI.Data.Models
{
    public class Autor
    {
        public int Id { get; set; }

        public string NomeCompleto { get; set; }

        //Navegação Propriedades
        public List<Livros_Autor> Livros_Autors { get; set; }
    }
}
