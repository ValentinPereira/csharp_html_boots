using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6partie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" renseigner un des 12 mois disponible"); // demande de d'écrire un mois de l'année
            string monthUser = Console.ReadLine(); // recupere le mois utilisé.
            
            switch(monthUser)
            {
                case "Mars":
                case "Avril":
                case "Mai":
                    Console.WriteLine("C'est le printemps");
                    break;
                case "Juin":
                case "Juillet":
                case "Aout":
                    Console.WriteLine("C'est l'été");
                    break;
                case "Septembre":
                case "Octobre":
                case "Novembre":
                    Console.WriteLine("C'est l'automne");
                    break;
                case "Décembre":
                case "Janvier":
                case "Février":
                    Console.WriteLine("C'est l'hiver");
                    break;
            }
        }
    }
}
