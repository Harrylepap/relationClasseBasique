using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationClasse
{
    class Principale
    {
        static void Main(string[] args)
        {
            Personne harry = new Personne("Bako", "Harry");
            Voiture evoque = new Voiture(harry);
            Console.ReadLine();
        }
    }
}
