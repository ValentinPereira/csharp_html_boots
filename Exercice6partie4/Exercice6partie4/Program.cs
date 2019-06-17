using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6partie4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> months = new List <string> //Déclare une liste de type string month avec les 12 mois de l'années.
            { "janvier", "fevrier", "mars", "avril", "mai", "juin", "juillet", "aout", "septembre", "octobre", "novembre", "decembre"};
            foreach (string month in months) // Déclare avec la méthode foreach qu'on doit chercher les 12 mois dans la variable months à partir d'une nouvelle viable month.
            {
                Console.WriteLine(month); //Affiche le tableau
            }

        }
    }
}
