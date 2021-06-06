using MeusLivrosAPI.Data.Models;
using MeusLivrosAPI.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeusLivrosAPI.Data.Services
{
    public class LivrosService
    {
        private AppDbContext _context;
        public LivrosService(AppDbContext context)
        {
            _context = context;
        }
       
        public void AddLivrosWithAutors(LivroFJ livro)
        {
            var _livro = new Livros
            {
                Titulo = livro.Titulo,
                Descricao = livro.Descricao,
                IsRead = livro.IsRead,
                DataLeitura = livro.IsRead ? livro.DataLeitura.Value : null,
                Avaliacao = livro.IsRead ? livro.Avaliacao.Value : null,
                Genero = livro.Genero,
                CoverUrl = livro.CoverUrl,
                DataAdicao = DateTime.Now,
                PublicarId = livro.PublicarId
            };
            _context.Livros.Add(_livro);
            _context.SaveChanges();
                        

            foreach (var id in livro.AutorIds)
            {
                var _livros_autor = new Livros_Autor()
                {
                   LivrosId = _livro.Id,
                   AutorId = id
                };
                _context.Livros_Autors.Add(_livros_autor);
                _context.SaveChanges();
            }
        }

        public List<Livros> GetAllLivros() => _context.Livros.ToList();

        public LivroWithAutorsFJ GetLivrosById(int livroId)
        {
            var _livroWithAutors = _context.Livros.Where(n => n.Id == livroId).Select(livro => new LivroWithAutorsFJ()
            {
                Titulo = livro.Titulo,
                Descricao = livro.Descricao,
                IsRead = livro.IsRead,
                DataLeitura = livro.IsRead ? livro.DataLeitura.Value : null,
                Avaliacao = livro.IsRead ? livro.Avaliacao.Value : null,
                Genero = livro.Genero,
                CoverUrl = livro.CoverUrl,
                PublicarNome = livro.Publicar.Nome,
                AutorNomes = livro.Livros_Autors.Select(n => n.Autor.NomeCompleto).ToList()
            }).FirstOrDefault();
            return _livroWithAutors;
        }

        public Livros UpdateLivrosById(int livroId, LivroFJ livro)
        {
            var _livro = _context.Livros.FirstOrDefault(n => n.Id == livroId);
            if (_livro != null)
            {
                _livro.Titulo = livro.Titulo;
                _livro.Descricao = livro.Descricao;
                _livro.IsRead = livro.IsRead;
                _livro.DataLeitura = livro.IsRead ? livro.DataLeitura.Value : null;
                _livro.Avaliacao = livro.IsRead ? livro.Avaliacao.Value : null;
                _livro.Genero = livro.Genero;
                _livro.CoverUrl = livro.CoverUrl;
                _context.SaveChanges();
            }
            return _livro;
        }


        public void DeleteLivrosById(int livroId)
        {
            var _livro = _context.Livros.FirstOrDefault(n => n.Id == livroId);
            if (_livro != null)
            {
                _context.Livros.Remove(_livro);
                _context.SaveChanges();
            }
        }
    }
}
