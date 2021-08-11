using ChallengeDisneyAPI.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeDisneyAPI.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class moviesController : ControllerBase
    {
        private readonly ChallengeContext _context;
        public moviesController(ChallengeContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var listado = await _context.Characters.FirstOrDefaultAsync();
            return Ok();
        }


    }
}
