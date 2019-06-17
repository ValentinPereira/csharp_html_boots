﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice5partie2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fujita = new string[6] { "FO", "F1", "F2", "F3", "F4", "F5" };

            {
                fujita[0] = " F0 Dégâts légers : certains dommages sont subis par les cheminées, les antennes de télévision, les bardeaux, les arbres, " +
                            " les enseignes et les fenêtres.";
                fujita[1] = " F1 Dégâts modérés: les automobilessont renversées, les abris " +
                            " pour automobiles détruits et les arbres déracinés.";
                fujita[2] = " F2 Dégâts importants : les toits sont arrachés par le vent, les hangars " +
                            "et les dépendances sont démolies et les maisons mobiles sont renversées.";
                fujita[3] = " F3 Dégâts considérables : les murs extérieurs et les toits sont projetés dans les airs, " +
                            "les maisons et les bâtiments de métal s'effondrent ou subissent des dégâts";
                fujita[4] = " F4 Dégâts dévastateurs : même dans les habitations solides, l'essentiel des murs, " +
                            "sinon tous, s'effondrent ; tels des missiles, de gros objets en acier ou en béton sont projetés à grandes distances.";
                fujita[5] = " F5 Dégâts incroyables : les maisons sont rasées ou projetées sur de grandes distances. " +
                            "Les tornades F5 peuvent causer des dommages très importants à de grosses structures telles que les écoles et les motels et peuvent arracher les murs extérieurs et les toits (parfois surnommé « le doigt de Dieu ».";

                for (int i = 0; i < fujita.Length; i++)
                {
                    Console.WriteLine(fujita[i]);
                }
            }
            
        }
    }
}