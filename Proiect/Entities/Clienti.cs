using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect.Entities
{

    [Serializable]
    public class Clienti
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }


        public Clienti()
        {

        }

        public Clienti(string FirstName,string LastName,int Telefon,string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Telefon = Telefon;
            this.Email = Email;
        }

        
    }
}
