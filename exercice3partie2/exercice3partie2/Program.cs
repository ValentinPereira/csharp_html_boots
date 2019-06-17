using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice3partie2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("saisir votre civilité."); // je demande à l'utilisateur des renseignements
            string civility = Console.ReadLine(); // je recupere la civilité saisie.
            
            Console.WriteLine("saisir votre age.");
            string age = Console.ReadLine(); // Je recupere l'age.
            bool verif = int.TryParse(age, out int ageNum); // j'essaye de convertir la saisie en int si ça marche sinon c'est faux
            if (verif)

                if (ageNum < 0 || ageNum > 0)
                    Console.WriteLine("saisie incorect");

            if (civility != "M." || civility != "Mme")
                Console.WriteLine(" Vous êtes quoi? ");

            {
                if (ageNum >= 18 && ageNum < 120 && civility == "M.")
                {
                    Console.WriteLine(" Vous êtes un homme et vous avez " + ageNum + "ans, vous êtes donc majeur.");
                }
                else if (ageNum >= 18 && ageNum < 120 && civility == "Mme")
                {
                    Console.WriteLine(" Vous êtes une femme et vous avez " + ageNum + "ans, vous êtes donc majeur.");
                }

                else if (ageNum < 18 && ageNum > 0 && civility == "M.")
                {
                    Console.WriteLine(" Vous êtes un homme et vous avez " + ageNum + "ans, vous êtes donc mineur.");
                }

                else if (ageNum < 18 && ageNum > 0 && civility == "Mme")
                {
                    Console.WriteLine(" Vous êtes une femme et vous avez " + ageNum + "ans, vous êtes donc mineur.");
                }
                else
                {
                    Console.WriteLine(" unknow");
                }

            }
        }
    }
 } 
