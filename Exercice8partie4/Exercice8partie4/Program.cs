 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice8partie4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pair = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }; // Déclare un tableau à 20 chiffres avec le type int 
            for (int i = 0; i <= 20; i++) // Déclare que la boucle commence à 0 et s'incrémente de 1 jusqu'a 20.
            {
                if (i % 2 > 0)
                {
                    continue;
                }
                Console.WriteLine(i); // Affiche le tableau avec les chiffres pairs

            }/* ou foreach (int pairs in pair) à  la place de for
            if (i % 2 == 0)
            Console... */
        }
    }
}
