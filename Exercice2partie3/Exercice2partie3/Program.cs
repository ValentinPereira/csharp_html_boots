using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2partie3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[7]; //Crée un tableau de type string avec une chaîne de 7 éléments.
            week[0] = "lundi"; // Attribut la valeur lundi à l'indice 0 du tableau.
            week[1] = "mardi";
            week[2] = "mercredi";
            week[3] = "jeudi";
            week[4] = "jeudi";
            week[5] = "samedi";
            week[6] = "dimanche";
            Console.WriteLine(week[0]); // Affiche le tableau week.
            Console.WriteLine(week[1]); // Affiche le tableau week.
            Console.WriteLine(week[2]); // Affiche le tableau week.
            Console.WriteLine(week[3]); // Affiche le tableau week.
            Console.WriteLine(week[4]); // Affiche le tableau week.
            Console.WriteLine(week[5]); // Affiche le tableau week.
            Console.WriteLine(week[6]); // Affiche le tableau week.

            week[4] = "vendredi"; //Modification de la valeur jeudi.

            Console.WriteLine(week[0]); // Affiche le tableau week.
            Console.WriteLine(week[1]); // Affiche le tableau week.
            Console.WriteLine(week[2]); // Affiche le tableau week.
            Console.WriteLine(week[3]); // Affiche le tableau week.
            Console.WriteLine(week[4]); // Affiche le tableau week.
            Console.WriteLine(week[5]); // Affiche le tableau week.
            Console.WriteLine(week[6]); // Affiche le tableau week.










        }
    }
}
