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
    public class PublicarController : ControllerBase
    {
        private PublicarService _publicarService;

        public PublicarController(PublicarService publicarService)
        {
            _publicarService = publicarService;
        }

        //Post: PublicarController
        [HttpPost("add-publicar")]
        public IActionResult AddLivros([FromBody] PublicarFJ publicar)
        {
            _publicarService.AddPublicar(publicar);
            return Ok();
        }

        //Get: PublicarController
        [HttpGet("get-publicar-livros-with-autor{id}")]
        public IActionResult GetPublicarData(int id)
        {
            var _response = _publicarService.GetPublicarData(id);
            return Ok(_response);
        }


        //Delete: PublicarController
        [HttpDelete("delete-publicar-by-id")]
        public IActionResult DeletePublicarById(int id)
        {
            _publicarService.DeletePublicarById(id);
            return Ok();
        }
    }
}
