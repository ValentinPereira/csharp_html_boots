using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2partie4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1; // Déclare une variable i de valeur 1
            while (i <= 10) // Indique que la boucle est inférieur ou égal à 10
            {
                Console.WriteLine(" Bonjour je suis la phrase" + i); // Affiche Bonjour je suis la phrase n°+i Jusqu'a 10 et s'incrémente de 1.
                i++; // Incrémente de 1
                
            }
        }
    }
}
