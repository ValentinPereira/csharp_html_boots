using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4partie3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopping = new List<string>(); // Création dela liste et définis le contenu.
            shopping.Add("carotte"); //Attribut la valeur carotte
            shopping.Add("tomate");
            shopping.Add("pomme de terre");
            shopping.Add("oignons");
            shopping.Add("salade");
            // string elementShopping = ; // Recherche un élément dans la liste.
            Console.WriteLine(shopping[2]); //Affiche l'élement grace au numéro.
        }
    }
}
