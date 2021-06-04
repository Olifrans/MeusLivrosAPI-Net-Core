using MeusLivrosAPI.Data.Models;
using MeusLivrosAPI.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeusLivrosAPI.Data.Services
{
    public class AutorsService
    {
        private AppDbContext _context;
        public AutorsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddAutor(AutorFJ livro)
        {
            var _autor = new Autor()
            {
                NomeCompleto = livro.NomeCompleto,             
            };
            _context.Autors.Add(_autor);
            _context.SaveChanges();
        }
    }
}
