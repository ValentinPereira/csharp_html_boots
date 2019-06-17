using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1partie3s
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[7] { "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche" }; // Définis un tableau de type string qui contient 7 chaînes de caractères.
            for (int i = 0; i < week.Length; i++) // boucle pour parcourir l'ensemble du tableau crée.
            {
                Console.WriteLine(week[i]); // Affiche le tableau.
            }
        }
    }
}
