using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect.Entities
{

    [Serializable]
    public class Clienti
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }


        public Clienti()
        {

        }

        public Clienti(string Nume)
        {
            this.FirstName = Nume;
        }

        public Clienti(string FirstName,string LastName,int Telefon,string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Telefon = Telefon;
            this.Email = Email;
        }

        public Clienti(long id, string FirstName, string LastName, int Telefon, string Email)
            :this(FirstName, LastName, Telefon, Email)
        {
            Id = id;

        }

        
    }
}
