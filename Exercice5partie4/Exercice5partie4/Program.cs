using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5partie4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" }; //Déclare un tableau days de type string des jours de la semaines.
            int indice; //Déclare une variable indice.
            for (indice = 0; indice < 7; indice++) //Avec la méthode for déclare que l'indice possède la valeur 0 et s'arrête à 7 et s'incrémente de 1.
            {
                Console.WriteLine(days[indice]);//Affiche les jours de la semaine.
            }
        }
    }
}
/* (indice = 0; indice < week.Lenght; indice++) QUAND ON NE CONNAIT PAS LA VALEUR DE SON TABLEAU.
 * {Console.WriteLine(days[indice]); */
