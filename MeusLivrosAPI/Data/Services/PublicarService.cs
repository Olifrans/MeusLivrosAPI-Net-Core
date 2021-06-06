using MeusLivrosAPI.Data.Models;
using MeusLivrosAPI.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeusLivrosAPI.Data.Services
{
    public class PublicarService
    {
        private AppDbContext _context;
        public PublicarService(AppDbContext context)
        {
            _context = context;
        }

        public void AddPublicar(PublicarFJ publicar)
        {
            var _publicar = new Publicar()
            {
                Nome = publicar.Nome,             
            };
            _context.Publicars.Add(_publicar);
            _context.SaveChanges();
        }



        public PublicarWithLivrosAndAutorFJ GetPublicarData(int publicarId)
        {
            var _publicarData = _context.Publicars.Where(n => n.Id == publicarId)
                .Select(n => new PublicarWithLivrosAndAutorFJ()
            {
                Nome = n.Nome,
                LivrosAutors = n.Livros.Select(n => new LivrosAutorFJ()
                {
                    LivrosNome = n.Titulo,
                    LivrosAutors = n.Livros_Autors.Select(n => n.Autor.NomeCompleto).ToList()
                }).ToList()
            }).FirstOrDefault();             
            return _publicarData;
        }

        public void DeletePublicarById(int id)
        {
            var _publicar = _context.Publicars.FirstOrDefault(n => n.Id == id);
            if (_publicar != null)
            {
                _context.Publicars.Remove(_publicar);
                _context.SaveChanges();
            }
        }
    }
}
