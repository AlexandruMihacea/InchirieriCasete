using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect.Entities
{
   public class Inchirieri 
    {
     
        private Filme Film { get; set; }
        private Clienti Client { get; set; }
        private int Price { get; set; }


        public Inchirieri( Filme Film, Clienti Client,int Price)
        {
            
            this.Client = Client;
            this.Film = Film;
            this.Price = Price;
        }
    }
}
