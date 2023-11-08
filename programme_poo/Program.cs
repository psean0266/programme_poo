using System;
using System.Collections.Generic;

namespace programme_poo
{
    class Personne
    {
        string nom;
        int age;
        string emploi;

        public Personne(string nom, int age, string emploi)
        {
            this.nom = nom;
            this.age = age;
            this.emploi = emploi;
        }

        public void Afficher()
        {
            Console.WriteLine("NOM : " + nom);
            Console.WriteLine(" AGE : " + age + " ans");
            Console.WriteLine("EMPLOI : " + emploi);
        }
    }
     class Program
    {

        //static void AfficherInfosPersonne(string nom, int age, string emploi)
        //{
        //    Console.WriteLine("NOM : " + nom);
        //    Console.WriteLine(" AGE : " + age + "ans");
        //    Console.WriteLine("EMPLOI : " + emploi);
        //}
        static void Main(string[] args)
        {
            // nom, age, emploi

            //var noms = new List<string> { "Paul", "Jacques", "David" };
            //var ages = new List<int> { 30, 35, 20 };
            //var emploi = new List<string> { "Développeur", "Professeur", "Etudiant" };

            //for (int i = 0; i < noms.Count; i++)
            //{
            //    AfficherInfosPersonne(noms[i], ages[i], emploi[i]);

            //}

            Personne personne1 = new Personne("Paul", 20, "Etudiant");
          //  personne1.Afficher(); 

            Personne personne2 = new Personne("Jacques", 38, "Professeur");
          //  personne2.Afficher();   

           var personnes = new List<Personne> {
           new Personne("Jacques", 38, "Professeur"),
           new Personne("Noe", 38, "ETUDIANT"),
           new Personne("Farid", 38, "Comptable"),
           new Personne("Kaaris", 38, "Artiste"),
           new Personne("Megane", 38, "Tiktokeuse"),
        };

            //for (int i = 0; i < personnes.Count; i++)
            //{
            //    personnes[i].Afficher();
            //  //  Console.WriteLine(" Personnes : " + personnes[i]);
            //}

            foreach (Personne personne in personnes) {
            personne.Afficher();
            }
        }
    }
}
