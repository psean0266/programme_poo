﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace programme_poo
{

    class Enfant : Etudiant
    {
        Dictionary<string, float> notes;
        string classeEcole;
        //  public Personne professeurPrincipal { get; init; }
        public Enfant(string nom, int age, string classeEcole, Dictionary<string, float> notes) : base(nom, age, null)
        {
            this.classeEcole = classeEcole;
            this.notes = notes;
        }

        public override void Afficher()
        {
            float moyenne;
            float total = 0;
            AfficherNomEtAge();
            Console.WriteLine("Enfant en classe de CP" + classeEcole);
            AfficherProfesseurPrincipal();

            if ((notes != null) && (notes.Count > 0))
            {
                Console.WriteLine("Note Moyenne");
                foreach (var note in notes)
                {
                    total += note.Value;
                    Console.WriteLine(" " + note.Key + " : " + note.Value + " / 10");
                }

                moyenne = total / notes.Count;

                Console.WriteLine("La moyenne  de l'enfant : " + moyenne);

            }
        }
    }


    class Etudiant: Personne
    {
        string infoEtudes;
        public Personne professeurPrincipal { get; init; }
        public Etudiant(string nom, int age, string infoEtudes) : base(nom, age, "ETUDIANT")
        {
            this.infoEtudes = infoEtudes;
   
        }


        public override void Afficher()
        {
            AfficherNomEtAge();
            Console.WriteLine("Etudiant en : " + infoEtudes);
            AfficherProfesseurPrincipal();
        }

        protected void AfficherProfesseurPrincipal()
        {
            if (professeurPrincipal != null)
            {
                Console.WriteLine();
                Console.WriteLine(" Le Professeur principal est: ");
                professeurPrincipal.Afficher();
            }

        }
    }
    class Personne : IAffichable
    {
        private static int nombrePersonnes = 0;
        // public string nom { private get; set; } // on bloque get ici mais on libère set

      //  int _age;
         public string nom { init; get; }  // pour seter la valeur uniquement pendant la construction et l'interdir après la construction
         public int age { init; get; }
         protected string emploi { get; init; }
         protected int numeroPersonne;

        //public string GetNom()
        //{
        //    return nom;
        //}

        //public void SetNom(string value)
        //{
        //    nom = value;
        //}

        #region Les méthode décomposé du constructeur
        //public Personne(string nom, int age)
        //{
        //    this.nom = nom;
        //    this.age = age;
        //    this.emploi = "(Non spécifié)";

        //    nombrePersonnes++;

        //    this.numeroPersonne = nombrePersonnes;
        //}


        //public Personne(string nom, int age, string emploi = "(Non spécifié)")
        //{
        //    this.nom = nom;
        //    this.age = age;
        //    this.emploi = emploi;

        //    nombrePersonnes++;

        //    this.numeroPersonne = nombrePersonnes;
        //}

        #endregion

        #region constructeur composé pour faire rendre facultatif emploi 

        //public Personne(string nom, int age): this(nom, age, "(Non spécifié)")
        //{
      
        //}

        public Personne(string nom, int age, string emploi = null )  // ça veut dire execute d'abord le premier constructeur qui n'a pas de parametre
        {
            this.nom = nom;
            this.age = age;
            this.emploi = emploi;
            nombrePersonnes++;
            this.numeroPersonne = nombrePersonnes;
        }

        #endregion
        public static void AfficherNombreDePersonnes()
        {
            Console.WriteLine(" Nombre total de numéro " +nombrePersonnes);
        }

        public virtual void Afficher()
        {
            AfficherNomEtAge();


            if (emploi == null)
            {
                Console.WriteLine("Aucun emploi spécifié");
            }

            else
            {
                Console.WriteLine("EMPLOI : " + emploi);
            }
                               
        }
        protected void AfficherNomEtAge()
        {
            Console.WriteLine("PERSONNE N° : " + numeroPersonne);
            Console.WriteLine("NOM : " + nom);
            Console.WriteLine(" AGE : " + age + " ans");
        }
    }

    class TableDeMultiplication : IAffichable
    {
        int numero;
        public TableDeMultiplication( int numero)
        {
            this.numero = numero;
        }

        public void Afficher()
        {
            Console.WriteLine("Table de multîplication  de " + numero);

            for(int i = 0; i <= 10; i++) {

                Console.WriteLine(" " + i + " x " + numero + " = "+ (numero*i) );

            }
        }

    }

    interface IAffichable
    {
        void Afficher();
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

            
                    //var personnes = new List<Personne> {
                    //   new Personne("Jacques", 30, "Dévéloppeur"),
                    //   new Personne("Noe", 35, "Professeur"),
                    //   new Etudiant("Farid", 20, "Philo"),
                    //   new Enfant("Juliette", 8, "CP", null),

                    //};


            var elements = new List<IAffichable> {
                       new Personne("Jacques", 30, "Dévéloppeur"),
                       new Personne("Noe", 35, "Professeur"),
                       new Etudiant("Farid", 20, "Philo"),
                       new Enfant("Juliette", 8, "CP", null),
                       new TableDeMultiplication(2),

                    };

           // elements = elements.Where(p => (p.nom[0]=='J')&&(p.age>=30)).ToList();
          //  personnes = personnes.Where(p => p is Enfant).ToList();
            // personnes = personnes.Where(p => p.age >= 25).ToList();   
            //personnes = personnes.OrderBy(p => p.nom).ToList(); 
            foreach (var element in elements)
            {
                element.Afficher();

            }

            Personne.AfficherNombreDePersonnes();

            //var personne1 = new Personne { nom = "Paul", age = 30, emploi = "INGENIEUR" };
            //var personne2 = new Personne ( "Karim", 30, "PROFESSEUR" );

            //var professeur = new Personne("Mr le prof", 40, "Docteur");

            Personne professeur = null;

            var etudiant = new Etudiant("David2", 20, "Ecole d'ingénieur informatique")
            {
                //  professeurPrincipal = new Personne("Mr le prof", 40, "Docteur2")
                professeurPrincipal = professeur
            };

            //  etudiant.professeurPrincipal = new Personne("Mr le prof", 40, "Docteur2");

 
            etudiant.Afficher();

            var notesEnfant1 = new Dictionary<string, float>
          {
                {"Maths", 5f },
                {"Geo", 8.5f },
                {"Dicté", 3.5f }
          };

            var enfant = new Enfant("Sophie", 6,"1", notesEnfant1)
            {
              //  classeEcole = "1",
                professeurPrincipal = new Personne("Mr Paul", 40, "Instituteur")

            };

            enfant.Afficher();

            //var table2 = new TableDeMultiplication(2);

            //table2.Afficher(); 

        }
    }
}
