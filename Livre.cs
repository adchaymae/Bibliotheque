using System;
namespace GLivreLM.Models
{
    public class Livre
    {
        public int Isbn { get; set; }
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public DateTime DateEdition { get; set; }
        public string Resume { get; set; }
    }
}

