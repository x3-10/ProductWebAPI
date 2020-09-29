﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NovaKeepWebAPI.Interfaces;
using NovaKeepWebAPI.Models;

namespace NovaKeepWebAPI.Repositories
{


    public class CharacterRepo : ICharacterRepo
    {
        private readonly AppDbContext _db;

        public CharacterRepo(AppDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Character> GetAllCharacters()
        {
            List<Character> listResult;
            listResult = _db.characters.ToList<Character>();

            return listResult;
        }
        public Character GetCharacter(int id)
        {
            Character character = new Character();
            character = _db.characters.FirstOrDefault<Character>(x => x.characterID == id);
            return character;
        }
        public Character InsertCharacter(Character character)
        {
            _db.CharacterTable.Add(character);
            _db.SaveChanges();
            return character;
        }

        public Character UpdateCharacter(Character characterWithChanges)
        {
            Character character = _db.characters.FirstOrDefault(x => x.characterID == characterWithChanges.characterID);
            if(character!= null)
            {

                //product.productID = productWithChanges.productID;
                character.firstName = characterWithChanges.firstName;
                character.lastName = characterWithChanges.lastName;
                character.age = characterWithChanges.age;
                character.hometown = characterWithChanges.hometown;
                character.ability = characterWithChanges.ability;
                character.weapon = characterWithChanges.weapon;
                character.userAccountedId = characterWithChanges.userAccountedId;
                _db.characters.Update(character);
                _db.SaveChanges();
            }
            return character;
        }

        public Character DeleteCharacter(int id)
        {
            Character character = new Character();
            character = _db.characters.FirstOrDefault<Character>(x => x.characterID == id);

            if (character != null)
            {
                _db.characters.Remove(character);
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
