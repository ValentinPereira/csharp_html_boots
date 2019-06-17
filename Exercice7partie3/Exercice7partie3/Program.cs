using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice7partie3
{
    class Program
    {

        enum week  // Déclare le tableau enumération
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi = 4,   //Donne une valeur à vendredi
            Samedi,
            Dimanche
        }

        static void Main(string[] args)    //Affiche l'énumération 
        {
            week lundi = week.Lundi;
            Console.WriteLine(lundi);      //OU ($"{week.Lundi}, ...
            week mardi = week.Mardi;
            Console.WriteLine(mardi);
            week mercredi = week.Mercredi;
            Console.WriteLine(mercredi);
            week jeudi = week.Jeudi;
            Console.WriteLine(jeudi);
            week vendredi = week.Vendredi;
            Console.WriteLine(vendredi);
            week samedi = week.Samedi;
            Console.WriteLine(samedi);
            week dimanche = week.Dimanche;
            Console.WriteLine(dimanche);

            string value4 = Enum.GetName(typeof(week), 4); //Affichage de la variable changée
            Console.WriteLine(value4);


        }
    }
}