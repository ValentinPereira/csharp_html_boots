using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4partie4
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter; //Déclare une variable compte 
            for (counter = 10; counter >= 0; counter--) // Utilise boucle for et décompte de 10 à 0 et se décrémente de 1.
            {
                Console.WriteLine(counter); // Affiche le décompte de 10 à 0.
            }
            Console.ReadKey();
        }
    }
}
