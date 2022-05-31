using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compte2
{
    public class Devise
    {
        private double valeur;

        public Devise()
        {
        }

        public Devise(double v)
        {
            this.valeur = v;
        }
        public void afficher()
        {
            Console.WriteLine("valeur :" + this.valeur);
        }

        public static Devise operator-(Devise d)
        {
            Devise devise = new Devise();
            devise.valeur -= d.valeur;
            return devise;
        }
        public static Devise operator+(Devise d1, Devise d2)
        {

            d1.valeur += d2.valeur;
            return d1;
        }
        public static Devise operator -(Devise d1, Devise d2)
        {

            d1.valeur -= d2.valeur;
            return d1;
        }
        public static bool operator>=(Devise d, Devise v)
        {
            return d.valeur >= v.valeur;
        }
        public static bool operator<=(Devise d, Devise v)
        {
            return d.valeur <= v.valeur;
        }

    }
}
