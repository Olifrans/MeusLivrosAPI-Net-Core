using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeusLivrosAPI.Data.ViewModels
{
    public class LivroFJ
    {
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public bool IsRead { get; set; }

        public DateTime? DataLeitura { get; set; }

        public int? Avaliacao { get; set; }

        public string Genero { get; set; }

        public string CoverUrl { get; set; }


        public int PublicarId { get; set; }

        public List<int> AutorIds { get; set; }
    }


    public class LivroWithAutorsFJ
    {
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public bool IsRead { get; set; }

        public DateTime? DataLeitura { get; set; }

        public int? Avaliacao { get; set; }

        public string Genero { get; set; }

        public string CoverUrl { get; set; }

        public string PublicarNome { get; set; }

        public List<string> AutorNomes { get; set; }
    }
}
