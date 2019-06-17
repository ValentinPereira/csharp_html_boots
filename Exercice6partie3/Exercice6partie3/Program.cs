using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6partie3
{
    class Program
    {
            enum week   // déclare l'énumération avec les jours de la semaines
            {
                Lundi,
                Mardi,
                Mercredi,
                Jeudi,
                Vendredi,
                Samedi,
                Dimanche
            }

            static void Main(string[] args)
            {
                
                week lundi = week.Lundi;    // Affiche l'énumération sans bouble grâce à l'opérateur point et le nom de l'énumération
                Console.WriteLine(lundi);    
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


            
            }
        }
    }
 
