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


        public AutorWithLivrosFJ GetAutorWithLivros(int autorId)
        {
            var _autor = _context.Autors.Where(n => n.Id == autorId).Select(n => new AutorWithLivrosFJ()
            {
                NomeCompleto = n.NomeCompleto,
                LivrosTitulos = n.Livros_Autors.Select(n => n.Livros.Titulo).ToList()
            }).FirstOrDefault();
            return _autor;
        }
    }
}
