using System;
using System.Collections.Generic;
using System.Text;


namespace Proiect.Entities
{
   public class Filme
    {
        public string Nume { get; set; }
        public int Durata { get; set; }


        public Filme(string Nume, int Durata)
        {
            this.Nume = Nume;
            this.Durata = Durata;
        }
    }
}
