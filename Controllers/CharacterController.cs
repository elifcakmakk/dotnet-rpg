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
       // private static List<Character> characters;
//
       // public CharacterController()
       // {
       //     characters = new List<Character> {
       //                     new Character(),
       //                     new Character(){Name ="elif"},
       //                     new Character { Id = 1, Name ="Sam" }
       //                     };
       // }
        private static Character knight = new Character();

          private static List<Character> characters = new List<Character> {
              new Character(),
              new Character(){Name ="elif"},
              new Character { Id = 1, Name ="Sam" }
          };     

        [HttpGet("GetAll")]
        public IActionResult Get() //iactionresut jsonresult viewresult
        {
           return Ok(characters);
          // return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]
        public IActionResult AddCharacter(Character newCharacter){
            characters.Add(newCharacter);
            return Ok(characters);
        }
    }
}