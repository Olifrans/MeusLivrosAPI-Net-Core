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
    }
}
