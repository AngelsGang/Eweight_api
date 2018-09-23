using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class User
    {
        private string name;
        private string prenom;
        private decimal age;
        private string email;
        private decimal taille;
        private string password;
        private bool etat;

        public User()
        {
            etat = false;
        }

        public string Name { get => name; set => name = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public decimal Age { get => age; set => age = value; }
        public string Email { get => email; set => email = value; }
        public decimal Taille { get => taille; set => taille = value; }
        public string Password { get => password; set => password = value; }
        public bool Etat { get => etat; set => etat = value; }
    }
}

