using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2partie2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine(" saisir votre âge ");
            string age = Console.ReadLine());
            bool verif = int.TryParse(age, out int ageNum);
            
            if (verif)
            {

                if (ageNum >= 18)
                {
                    Console.WriteLine(" Vous avez" + age + "ans, vous êtes donc majeur.");
                }
                else if (ageNum < 0 || ageNum > 120);

            {
                Console.WriteLine("vous n'êtes pas née ou age incorect");
            }

            {
                Console.WriteLine(" Vous avez" + age + "ans, vous êtes donc mineur.");
            }

        }
    }
}
