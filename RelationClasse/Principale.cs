using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationClasse
{
    class Principale
    {
        public static int displayMenuPrincipale()
        {
            Console.WriteLine("Bienvenu sur l'application ");
            Console.WriteLine("1 - Pour voir les conducteurs de la voiture. ");
            Console.WriteLine("2 - Pour ajouter des conducteurs à la voiture. ");
            Console.WriteLine("3 - Pour verifier si une personne est un conducteur");
            Console.WriteLine("4 - Pour verifier si la personne est proprietaire");
            Console.Write("Votre choix est : ");

            return int.Parse(Console.ReadLine());
        }


        static void Main(string[] args)
        {
            int choix = 0;
            string nom = null;
            Voiture evoque;
            Personne utilisateur = new Personne();

            Console.Write("Veuillez-vous identifier : ");
            nom = Console.ReadLine(); utilisateur.Nom = nom; evoque = new Voiture(utilisateur);


            while (choix != 0 || choix != 5 )
            {
                choix = displayMenuPrincipale();
                if (choix == 5 || choix == 0)
                {
                    Console.WriteLine("Merci d'avoir utiliser l'application.");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    switch (choix)
                    {
                        case 1:
                            Console.WriteLine("Listes de tous les conducteurs :");
                            if (evoque.Conducteur.Count > 0)
                            {
                                foreach (Personne i in evoque.Conducteur)
                                {
                                    Console.WriteLine("- " + i.Nom + " " + i.Prenom);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Vous seule conduisez cette voiture. ");
                            }
                            
                            break;

                        case 2:
                            string anom, prenom = null;
                            Console.Write("Nom nouveau conducteur : "); anom = Console.ReadLine();
                            Console.Write("Prenom nouveau conducteur : "); prenom = Console.ReadLine();
                            evoque.Conducteur.Add(new Personne(anom, prenom));
                            break;
                        case 3:
                            string atester;
                            Console.WriteLine("Le nom ou prenom a testé :"); atester = Console.ReadLine();
                            foreach(Personne i in evoque.Conducteur)
                            {
                                if(i.Nom == atester || i.Prenom == atester)
                                {
                                    Console.WriteLine(atester + " EST un conducteur");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine(atester + " PAS un conducteur");
                                }
                            }
                            break;
                        case 4:
                            string atester1;
                            Console.WriteLine("Le nom ou prenom a testé :"); atester1 = Console.ReadLine();
                            if(evoque.Proprietaire.Nom == atester1 || evoque.Proprietaire.Prenom == atester1)
                            {
                                Console.WriteLine(atester1 + " EST proprietaire");
                            }
                            else
                            {
                                Console.WriteLine(atester1 + " PAS proprietaire");
                            }
                            
                            break;
                        default:
                            {
                                Console.WriteLine("Je n'ai pas compris ce que tu veux dire, réessayer s'il vous plait .");
                                break;
                            }
                            
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
