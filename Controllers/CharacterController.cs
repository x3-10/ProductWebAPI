using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NovaKeepWebAPI.Interfaces;
using NovaKeepWebAPI.Models;
using NovaKeepWebAPI.Repositories;

namespace NovaKeepWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class CharacterController : Controller
    {
        private readonly ICharacterRepo _characterRepo;

        public CharacterController(ICharacterRepo characterRepo)
        {
            _characterRepo = characterRepo;
        }
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Character> characters = null;
            characters = _characterRepo.GetAllCharacters();
            return Ok(characters);
        }
        //get:api/<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {

                Character character = null;

                character = _characterRepo.GetCharacter(id);

                if (character != null)
                {
                    return Ok(character);
                }
                else
                {
                    return NotFound("Character with Id = " + id.ToString() + " not found to display.");


                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
