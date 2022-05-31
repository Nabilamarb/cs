using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compte1
{
     public class Client
    {
        private string nom;
        private string prenom;
        private string addresse;

        public Client(string n, string p, string a)
        {
            this.nom = n;
            this.prenom = p;
            this.addresse = a;
        }
        public void afficher()
        {
            Console.WriteLine(this.ToString());
        }
        public override string ToString()
        {
            string s = "nom :" + this.nom + "\n" +
                "prenom :" + this.prenom + "\n" +
                "addresse :" + this.addresse;
            return s;
        }
    }
}
