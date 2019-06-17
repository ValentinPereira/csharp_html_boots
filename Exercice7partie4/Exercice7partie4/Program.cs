using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice7partie4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 }; // Déclare un tableau à 20 chiffres
            for (int number = 0; number <= 10; number++) // Déclare que le tableau commence à 0 et doit s'arréter à 10 avec une incrémentation de 1
            {
                Console.WriteLine(numbers[number]); //Affiche les dix premiers chiffres du tableau.
            }

                /* ou foreach (int number in numbers.Take(10)) Pour chaque élément dans numbers prendre les 10 premiers.
                 * Console.WriteLine(numbers[number]); */
        }
    }
}
