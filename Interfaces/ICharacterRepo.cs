
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovaKeepWebAPI.Models;

namespace NovaKeepWebAPI.Interfaces
{
    public interface ICharacterRepo
    {
        IEnumerable<Character> GetAllCharacters();

        Character GetCharacter(int id);

        Character InsertCharacter(Character character);
        Character UpdateCharacter(Character characterWithChanges);
        Character DeleteCharacter(int id);
        
    }
}
