using System;
using System.Threading.Tasks;
using Api.Data;
using Api.Dtos;
using Api.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterRepository _repository;
        public CharacterController(ICharacterRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetCharacters()
        {

            var characters = await _repository.GetCharacters();
            return Ok(characters);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateCharacter(CharacterForCreateDto characterForCreateDto)
        {

            if(await _repository.CharacterExist(characterForCreateDto.Nickname))
                return BadRequest("Character with that nickname exist!");

            var characterToCreate = new Character
            {
                Nickname = characterForCreateDto.Nickname,
                UserId = Convert.ToInt32(characterForCreateDto.UserId),
                Level = 1,
                Experience = 1,
                FullHealth = 100,
                FullMana = 100,
                Cp = 1
            };
            
            await _repository.CreateCharacter(characterToCreate);

            return StatusCode(201);

        }
    }
}