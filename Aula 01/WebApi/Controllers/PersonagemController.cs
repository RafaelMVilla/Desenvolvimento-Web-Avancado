using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;
=======
using WebApi.Data;
>>>>>>> 6fca3f4856843733c26556df7c1efdbf604906ba

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonagemController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public PersonagemController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

<<<<<<< HEAD
        [HttpPost]

        public async Task<IActionResult> AddPersonagem(Personagem personagem)
        {
            if (personagem == null)
            {
                return BadRequest("Dados Inválidos!");
            }

            _appDbContext.WebApiDB.Add(personagem);
            await _appDbContext.SaveChangesAsync();
            return StatusCode(201, personagem);
        }

        [HttpGet]
        public async Task<ActionResult <IEnumerable<Personagem>>> GetPersonagem()
        {
            var personagens = await _appDbContext.WebApiDB.ToListAsync();
            
            return Ok(personagens);
        }
=======
        
>>>>>>> 6fca3f4856843733c26556df7c1efdbf604906ba
    }
}