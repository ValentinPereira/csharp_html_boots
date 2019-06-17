using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice6exo_poumbrello
{
    class BankAccount
    {
        public int id;            // je déclare les attributs de la class BankAccount
        public string titular;      // alt gr4 + alt+} = les accolades
        public double solde;
        public string devise;
        // Je déclare la methode Credit avec entre parenthèse un parametre 
        // Elle permet de créditer le solde du compte bancaire avec le contenu dans le parametre
        public void Credit(double amount)
        {
            solde = solde + amount;            
        }
        public void Debit(double amount) // parametre de la methode debit 
        {
           solde = solde - amount; 
        }
    }
}

    //Exercice 8 
