using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeusLivrosAPI.Data.Models
{
    public class Livros
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public bool IsRead { get; set; }

        public DateTime? DataLeitura { get; set; }

        public int? Avaliacao { get; set; }

        public string Genero { get; set; }

        public string Autor { get; set; }

        public string CoverUrl { get; set; }

        public DateTime DataAdicao { get; set; }

        //Navegação Propriedades
        public int? PublicarId { get; set; }

        public Publicar Publicar { get; set; }

        public List<Livros_Autor> Livros_Autors { get; set; }
    }
}
