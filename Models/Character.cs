using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NovaKeepWebAPI.Models
{
    [Table("character")]
    public class Character
    {
        [Key]
        public int characterID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string age { get; set; }
        public string hometown { get; set; }
        public string ability { get; set; }
        public string weapon { get; set; }
        public string userAccountedId { get; set; }





    }
}
