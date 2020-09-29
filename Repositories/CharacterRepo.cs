using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovaKeepWebAPI.Interfaces;
using NovaKeepWebAPI.Models;

namespace NovaKeepWebAPI.Repositories
{


    public class CharacterRepo : ICharacterRepo
    {
        private readonly NovaKeepWebAPI.Models.ApplicationDbContext _db;

        public CharacterRepo(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Character> GetAllCharacters()
        {
            List<Character> listResult;
            listResult = _db.Characters.ToList<Character>();

            return listResult;
        }
        public Character GetCharacter(int id)
        {
            Character character = new Character();
            character = _db.Characters.FirstOrDefault<Character>(x => x.characterID == id);
            return character;
        }
        public Character InsertCharacter(Character character)
        {
            _db.Characters.Add(character);
            _db.SaveChanges();
            return character;
        }

        public Character UpdateCharacter(Character characterWithChanges)
        {
            Character character = _db.Characters.FirstOrDefault(x => x.characterID == characterWithChanges.characterID);
            if(character!= null)
            {

                //product.productID = productWithChanges.productID;
                character.first_name = characterWithChanges.first_name;
                character.last_name = characterWithChanges.last_name;
                character.age = characterWithChanges.age;
                character.hometown = characterWithChanges.hometown;
                character.ability = characterWithChanges.ability;
                character.weapon = characterWithChanges.weapon;
                character.UserAccountedId = characterWithChanges.UserAccountedId;
                _db.Characters.Update(character);
                _db.SaveChanges();
            }
            return character;
        }

        public Character DeleteCharacter(int id)
        {
            Character character = new Character();
            character = _db.Characters.FirstOrDefault<Character>(x => x.characterID == id);

            if (character != null)
            {
                _db.Characters.Remove(character);
                _db.SaveChanges();
            }

            return character;
        }

        public IEnumerable<Character> GetAllCharacters(int id)
        {
            throw new NotImplementedException();
        }
    }


}
