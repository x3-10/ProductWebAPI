using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovaKeepWebAPI.Models
{
    public class ApplicationDbContext:DbContext
    {
        //AppDbContext is 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {

        }
        //Dbset is a representation of the table in your db
        public DbSet<Character> Characters { get; set; }

    }
}
