using System;
using GLivreLM.Models;

namespace GLivreLM.Data
{
    public class LivreRepo
    {
        private static List<Livre> livres = new List<Livre>
        {
            new Livre
            {
                Isbn=1,
                Titre="ASP.NET",
                Auteur="qlq",
                DateEdition=new DateTime(2022,12,23),
                Resume="Cours/TP"
            }

        };

        public static List<Livre> GetLivres()
        {
            return livres;
        }
    }
}

