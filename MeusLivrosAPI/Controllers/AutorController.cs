using MeusLivrosAPI.Data.Services;
using MeusLivrosAPI.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeusLivrosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private AutorsService _autorsService;

        public AutorController(AutorsService autorsService)
        {
            _autorsService = autorsService;
        }

        //Post: AutorController
        [HttpPost("add-autor")]
        public IActionResult AddLivros([FromBody] AutorFJ autor)
        {
            _autorsService.AddAutor(autor);
            return Ok();
        }


        //Get: AutorController
        [HttpGet("get-autor-with-livros-by-id/{id}")]
        public IActionResult GetAutorWithLivros(int id)
        {
            var response = _autorsService.GetAutorWithLivros(id);
            return Ok(response);
        }
    }
}
