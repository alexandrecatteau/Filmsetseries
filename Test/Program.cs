using Moteur.Metier;
using System;
using Moteur.Repositories;
using Moteur.Repositories.Interface;
using Moteur.Utilitaires.Validateur;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "test";
            int testInt = 0;
            testInt.Valider(nameof(testInt)).StrictementPositif();

            Console.ReadKey();
        }
    }
}
