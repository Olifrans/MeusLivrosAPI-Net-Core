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

        // POST: LivrosController
        [HttpPost("add-autor")]
        public IActionResult AddLivros([FromBody] AutorFJ autor)
        {
            _autorsService.AddAutor(autor);
            return Ok();
        }
    }
}
