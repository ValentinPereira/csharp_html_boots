using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice6exo_poumbrello
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount AccountLaManu; // déclare l'objet du type de la classe (bank)
            AccountLaManu = new BankAccount // instancie avec la class bankAccount
            {
                titular = "LaManu",    // j'attribue
                solde = 2000,
                devise = "euros"
            };

            //EXO BONUS
            string userTitular;
            double userSolde;
            string userDevise;
            Console.WriteLine("Bonjour vous êtes à : ");
            userTitular = Console.ReadLine();
            Console.WriteLine("\nvous êtes à : " + AccountLaManu.titular);
            bool userSoldeIsNum = double.TryParse(Console.ReadLine(), out userSolde);
            while (!userSoldeIsNum)
            {
                Console.WriteLine("saisie incorrecte");
                double.TryParse(Console.ReadLine(), out userSolde);
            }
            Console.WriteLine("\nVotre compte est de : " + AccountLaManu.solde);
            userDevise = Console.ReadLine();
            Console.WriteLine("\nla devise est : " + AccountLaManu.devise);

            AccountLaManu.Credit(19);   // j'appelle la methode credit plus le parametre entre parenthese 
            //Console.WriteLine(AccountLaManu.titular);
            //Console.WriteLine(AccountLaManu.solde);
            //Console.WriteLine(AccountLaManu.devise);
            //Console.ReadLine();
        }
    }
}


