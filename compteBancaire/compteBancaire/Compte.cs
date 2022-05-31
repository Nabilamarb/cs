using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using compte1;
using compte2;

namespace compte
{
    public class Compte
    {
        private readonly int numcompte;
        private static int cpt = 0;
        private Client prop;
        private Devise solde;
        private Devise plafond;

        public Compte(Client prop, Devise solde)
        {
            this.prop = prop;
            this.solde = solde;
            this.numcompte = cpt++;
        }
         

        public bool crediter(Devise montant)
        {
           if(montant >= 0)
            {
                this.solde +=  montant;
                return true;
            }
            return false;
          

        }

        public bool debiter(Devise montant)
        {
            if (this.solde >=montant && montant<= this.plafond)
            {
                this.solde -= montant;
                return true;
            }
            return false;
        }

        public bool verser(Compte c, Devise montant)
        {
            if(this.debiter(montant)== true)
            {
                this.debiter(montant);
                c.crediter(montant);
                return true;
            }
            return false;
        }
    }
}
