using ChallengeDisneyAPI.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeDisneyAPI.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class CharactersController : ControllerBase
    {
        private readonly ChallengeContext _context;
        public CharactersController()
        {

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }


        [HttpPost]
        public void Post()
        {

        }


        [HttpPut]
        public void Put()
        {

        }


        [HttpDelete]
        public void Delete()
        {

        }
    }
}
