using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NovaKeepWebAPI.Models
{
    [Table("CharacterTable")]
    public class Character
    {
        [Key]
        public int characterID { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int age { get; set; }
        public string hometown { get; set; }
        public string ability { get; set; }
        public string weapon { get; set; }
        public string bio { get; set; }
        public string UserAccountedId { get; set; }





    }
}
