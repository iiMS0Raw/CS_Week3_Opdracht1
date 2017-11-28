using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_Week3_Opdracht1
{
    public static class SeedArtiest
    {
        public static void InitializeArtiest(OpdrachtContext context)
        {
            //Check if any artists already exist.
            if (context.Artiest.Any())
            {
                return;   // DB has already been seeded, do nothing
            }

            var artiesten = new Artiest[]
            {
                new Artiest{Voornaam="Carson",Achternaam= "Alexander"},
                new Artiest{Voornaam="Meredith",Achternaam="Alonso"},
                new Artiest{Voornaam="Dova",Achternaam="Kin"},
                new Artiest{Voornaam="Ferhat",Achternaam="Monto"},
                new Artiest{Voornaam="Jan",Achternaam="Wapper"},
                new Artiest{Voornaam="Boogaard",Achternaam="Zwemles"},
                new Artiest{Voornaam="Jan Dino",Achternaam="Lulgroot"},
                new Artiest{Voornaam="Internetkabel",Achternaam="Hayder"},
            };
            foreach (Artiest a in artiesten)
            {
                context.Artiest.Add(a);
            }
            context.SaveChanges();

        }
    }
}
