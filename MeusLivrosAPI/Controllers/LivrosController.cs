using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeusLivrosAPI.Data.Services;
using MeusLivrosAPI.Data.ViewModels;


namespace MeusLivrosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        public LivrosService _livrosService;

        public LivrosController(LivrosService livrosService)
        {
            _livrosService = livrosService;
        }

        // GET: LivrosController
        [HttpGet("get-all-livros")]

        public IActionResult GetAllLivros()
        {
            var allLivros = _livrosService.GetAllLivros();
            return Ok(allLivros);
        }

        // GET: LivrosController BY ID
        [HttpGet("get-livros-by-id/{id}")]

        public IActionResult GetLivrosById(int id)
        {
            var livros = _livrosService.GetLivrosById(id);
            return Ok(livros);
        }

        // POST: LivrosController
        [HttpPost("add-livros")]
        public IActionResult AddLivro([FromBody] LivroFJ livro)
        {
            _livrosService.AddLivros(livro);
            return Ok();
        }

        // PUT: LivrosController
        [HttpPut("update-livros-by-id/{id}")]

        public IActionResult UpdateLivrosById(int id, [FromBody] LivroFJ livro)
        {
            var updateLivros = _livrosService.UpdateLivrosById(id, livro);
            return Ok(updateLivros);
        }

        // Delete: LivrosController
        [HttpDelete("delete-livros-by-id/{id}")]

        public IActionResult DeleteLivrosById(int id)
        {
            _livrosService.DeleteLivrosById(id);
            return Ok();
        }
    }
}
