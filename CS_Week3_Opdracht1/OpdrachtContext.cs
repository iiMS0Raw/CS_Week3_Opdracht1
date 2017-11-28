using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace CS_Week3_Opdracht1
{
    public class OpdrachtContext : DbContext
    {
        public DbSet<Artiest> Artiest { get; set; }
        public DbSet<Instrument> Instrument { get; set; }
        public DbSet<Popgroep> Popgroep { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Trusted_Connection=True;");
        }

        
    }
}
