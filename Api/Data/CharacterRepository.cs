using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Models;
using Game.Data;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly DataContext _context;
        public CharacterRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Character>> GetCharacters()
        {
            var characters = await _context.Characters.ToListAsync();
            return characters;
        }

        public async Task<Character> ChooseCharacter(int id)
        {
            var character = await _context.Characters.FirstOrDefaultAsync(x => x.Id == id);

            if(character == null)
            return null;

            return character;
        }

        public async Task<Character> CreateCharacter(Character character)
        {
            await _context.Characters.AddAsync(character);
            await _context.SaveChangesAsync();

            return character;
        }

        public async Task<bool> CharacterExist(string nickname)
        {
            if(await _context.Characters.AnyAsync(x => x.Nickname == nickname))
                return true;

            return false;
        }
    }
}