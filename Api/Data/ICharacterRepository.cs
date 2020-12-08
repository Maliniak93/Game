using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Models;

namespace Api.Data
{
    public interface ICharacterRepository
    {
        Task<IEnumerable<Character>> GetCharacters();
         Task<Character> ChooseCharacter(int id);
         Task<Character> CreateCharacter(Character character);
         Task<bool> CharacterExist(string nickname);
    }
}