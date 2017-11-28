using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CS_Week3_Opdracht1
{
    public static class SeedPopgroep
    {
        public static void InitializePopgroep(OpdrachtContext context)
        {
            //Check if any popgroepen already exist.
            if (context.Popgroep.Any())
            {
                return;   // DB has already been seeded, do nothing.
            }

            var popgroepen = new Popgroep[]
            {
                new Popgroep{Naam = "Broederliefde", Genre = "Hip-Hop"},
                new Popgroep{Naam = "Anbu", Genre = "Hip-Hop"},
                new Popgroep{Naam = "Teethgrinder", Genre = "Grindcore"},
                new Popgroep{Naam = "Miss May I", Genre = "Metalcore"},
                new Popgroep{Naam = "Hans Anders", Genre = "New Wave"},
                
            };
            foreach (Popgroep p in popgroepen)
            {
                context.Popgroep.Add(p);
            }
            context.SaveChanges();

        }
    }
}

