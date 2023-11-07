using System;
using System.Collections.Generic;

namespace programme_poo
{
     class Program
    {

        static void AfficherInfosPersonne(string nom, int age, string emploi)
        {
            Console.WriteLine("NOM : " + nom);
            Console.WriteLine(" AGE : " + age + "ans");
            Console.WriteLine("EMPLOI : " + emploi);
        }
        static void Main(string[] args)
        {
            // nom, age, emploi

            var noms = new List<string> { "Paul", "Jacques", "David" };
            var ages = new List<int> { 30, 35, 20 };
            var emploi = new List<string> { "Développeur", "Professeur", "Etudiant" };

            for (int i = 0; i < noms.Count; i++)
            {
                AfficherInfosPersonne(noms[i], ages[i], emploi[i]);

            }
        }
    }
}
