using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice4partie2
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "identifiant"; // Attribution dde la valeur identifiant.
            Console.WriteLine(" rentrer votre identifiant."); // demande un identifiants.
            string loginUser = Console.ReadLine();  //recupere l'identifiant
            string password = " mot de passe"; //Attribution de la valeur mot de passe. 
            Console.WriteLine(" rentrer votre mot de passe."); // demande le mp.
            string passwordUser = Console.ReadLine(); // recupere le mp
            if (login == loginUser && password == passwordUser) // donne l'ordre au login et password de correspondre aux données de l'utilisateur
            Console.WriteLine(" Bienvenue à la manu le havre"); //Affiche la phrase bienvenue au havre si il y a un bon identifiant et mot de passe.
            else
            Console.WriteLine(" mauvais identifiant ou mot de passe"); // Affiche la phrase mauvais identifiant ou mp si l'utilisateur c'est trompé 
        }
    }
}
