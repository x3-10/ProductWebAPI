﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovaKeepWebAPI.Models
{
    public class AppDbContext:DbContext
    {
        //AppDbContext is 
        public AppDbContext(DbContextOptions<NovaKeepWebAPI.Models.AppDbContext> options)
             : base(options)
        {

        }
        //Dbset is a representation of the table in your db
        public DbSet<Character> Characters { get; set; }

    }
}
