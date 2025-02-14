using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VtrConducteur
{
    class Program
    {
        static void Main(string[] args)
        {
            //voiture sans conducteur
            Voiture vtr = new Voiture("AZER45", "Audi","XYZ", DateTime.Now);
            //conducteur sans voiture
            Conducteur cdr = new Conducteur("Sow","",12345678, new DateTime(2000,01,01));

            //voiture avec conducteur
            Voiture vtr2 = new Voiture("D457845", "Ford","ABC", new DateTime(2020, 03, 15), cdr);
            //conducteur avec voiture
            Conducteur cdr2 = new Conducteur("Abdallah","",78945611,new DateTime(2005,12,15), vtr);

            string separe = "_______________________";
            Console.WriteLine(separe+ "Afficher conducteur sans voiture");
            Console.WriteLine(cdr.Afficher());
            Console.WriteLine(separe+ "Afficher voiture sans conducteur");
            Console.WriteLine(vtr.Afficher());

            Console.WriteLine(separe + "Afficher Concducteur2 avec voiture");
            Console.WriteLine(cdr2.Afficher());
            Console.WriteLine(separe + "Afficher voiture2 avec conducteur");
            Console.WriteLine(vtr2.Afficher());

            Console.WriteLine(separe+"Ajouter voiture pour le chauffeur2");
            cdr2.ChangerVoiture(vtr2);
            Console.WriteLine(cdr2.Afficher());

            Console.WriteLine(separe+"Réafficher la voiture2");
            Console.WriteLine(vtr2.Afficher());
        }
    }
}
