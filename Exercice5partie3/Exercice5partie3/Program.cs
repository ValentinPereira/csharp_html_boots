using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5partie3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(); // création de la liste numbers

            numbers.Add(3); // Attribut le chiffre 3.
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);

            Console.WriteLine(numbers[0]); //Affiche  l'indice demandé.
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);

            numbers.Insert(0, 1);

            numbers.Add(7);

            Console.WriteLine(numbers[0]); // Affiche le nouveau tableau.
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);
            Console.WriteLine(numbers[5]);
            Console.WriteLine(numbers[6]);
        }
    }
}
