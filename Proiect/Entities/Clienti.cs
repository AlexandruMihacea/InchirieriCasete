using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect.Entities
{
    public class Clienti
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }


        public Clienti(string FirstName,string LastName,int Age,string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Email = Email;
        }

        
    }
}
