using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace programme_poo
{

    class Etudiant: Personne
    {
        string infoEtudes;
        public Etudiant(string nom, int age) : base(nom, age,"ETUDIANT")
        {
           
        }

        public override void Afficher()
        {
            Console.WriteLine("PERSONNE N° : " + numeroPersonne);
            Console.WriteLine("NOM : " + nom);
            Console.WriteLine(" AGE : " + age + " ans");
            if (emploi == null)
            {
                Console.WriteLine("Aucun emploi spécifié");
            }

            else
            {
                Console.WriteLine("Etudiant en : " + emploi);
            };
        }
    }
    class Personne
    {
        private static int nombrePersonnes = 0;
        // public string nom { private get; set; } // on bloque get ici mais on libère set

      //  int _age;
         protected string nom { init; get; }  // pour seter la valeur uniquement pendant la construction et l'interdir après la construction
         protected int age;
         protected string emploi { init; get; }
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
            Console.WriteLine("PERSONNE N° : " + numeroPersonne);
            Console.WriteLine("NOM : " + nom);
            Console.WriteLine(" AGE : " + age + " ans");
            if(emploi == null)
            {
                Console.WriteLine("Aucun emploi spécifié");
            }

            else
            {
                Console.WriteLine("EMPLOI : " + emploi);
            }
            
            
            
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

            // Personne personne1 = new Personne("Paul", 20, "Etudiant");
            //  personne1.Afficher(); 

            // Personne personne2 = new Personne("Jacques", 38, "Professeur");
            //  personne2.Afficher();   
            /*
                       var personnes = new List<Personne> {
                       new Personne("Jacques", 38, "Professeur"),
                       new Personne("Noe", 38, "ETUDIANT"),
                       new Personne("Farid", 38, "Comptable"),
                       new Personne("Kaaris", 38, "Artiste"),
                       new Personne("Megane", 38, "Tiktokeuse"),
                       new Personne("Aristide", 38, "Footballeur"),
                    };

                        //for (int i = 0; i < personnes.Count; i++)
                        //{
                        //    personnes[i].Afficher();
                        //  //  Console.WriteLine(" Personnes : " + personnes[i]);
                        //}
                        //personnes = personnes.OrderBy(p => p.nom).ToList(); 
                        foreach (Personne personne in personnes) {
                        personne.Afficher();
                            //personne.nombrePersonnes;
                        }
                        Personne.AfficherNombreDePersonnes(); */

            //var personne1 = new Personne { nom = "Paul", age = 30, emploi = "INGENIEUR" };
            //var personne2 = new Personne ( "Karim", 30, "PROFESSEUR" );

            //   Console.WriteLine(personne1.GetNom());
            //  personne1.SetNom("Migos") ;

            //personne1.age = 5;



            //personne1.Afficher();

            var etudiant = new Etudiant("David",20);
            etudiant.Afficher();

        }
    }
}
