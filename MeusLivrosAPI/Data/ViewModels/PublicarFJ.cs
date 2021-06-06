using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeusLivrosAPI.Data.ViewModels
{
    public class PublicarFJ
    {
        public string Nome { get; set; }
    }

    public class PublicarWithLivrosAndAutorFJ
    {
        public string Nome { get; set; }
        public List<LivrosAutorFJ> LivrosAutors { get; set; }
    }

    public class LivrosAutorFJ
    {
        public string LivrosNome { get; set; }
        public List<string> LivrosAutors { get; set; }
    }
}
