using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1partie4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; //Déclare une variable int de valeur 0
            while (i <= 10) // Tant que i inférieur à 10 continuer la boucle
            {
                Console.WriteLine("Bonjour ceci est un simple message"); // Affiche le message bonjour ceci est un simple message
            i++; // incrémente de 1
            }

           // do
                i++;
            Console.WriteLine("Phrase...");
            while (i < 10) ;

            Console.ReadKey();

        }
    }
}
