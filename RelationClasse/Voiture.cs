using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationClasse
{
    class Voiture
    {
        private Personne proprietaire;
        private ArrayList conducteur;

        public Personne Proprietaire { get => proprietaire; set => proprietaire = value; }
        public ArrayList Conducteur { get => conducteur; set => conducteur = value; }

        public Voiture(Personne personne)
        {
            this.proprietaire = personne;
        }

        public Boolean verifieProprietaire(Personne personne)
        {
            if (personne == Proprietaire)
            {
                return true;
            }
            return false;
        }

        public Boolean estConducteur(Personne personne)
        {
            if (Conducteur.Count != 0)
            {
                foreach (Personne pers in Conducteur)
                {
                    if (pers == personne)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
