using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeusLivrosAPI.Data.ViewModels
{
    public class AutorFJ
    {
        public string NomeCompleto { get; set; }
    }   
    
    public class AutorWithLivrosFJ
    {
        public string NomeCompleto { get; set; }
        public List<string> LivrosTitulos { get; set; }
    }   
}
