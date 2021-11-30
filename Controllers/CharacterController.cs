using System.Collections.Generic;
using System.Linq;
using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character { Id = 1, Name = "Sam", Race = RpgRace.Halfling},
            new Character { Id = 2, Name = "Legolas", Class = RpgClass.Archer, Race = RpgRace.Elf}
        };

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id)
        {
            // If we don't find a character matching our id, return our default value.
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }
    }
}