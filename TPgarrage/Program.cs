using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TPgarrage
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero, modele, immat;
            int annee, marque;
            double prix;
            bool plaque;
            plaque = false;

            Console.WriteLine("Entrez l'immatriculation de la voiture ?");
            numero = Console.ReadLine();
            Console.WriteLine("Entrez l'année de mise en circulation ?");
            annee = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le code de la marque ?");
            marque = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le modèle du véhicule ?");
            modele = Console.ReadLine();
            Console.WriteLine("Entrez le prix de la voiture ?");
            prix = Double.Parse(Console.ReadLine());

            List<Voiture> monGarage = new List<Voiture>();
            Voiture voit1 = new Voiture("122XZERT", 2001, 1, "Saxo", 2345.50);
            Console.WriteLine("Numéro : " + voit1.getNumero());
            voit1.afficher();
            Voiture voit2 = new Voiture("187ASRT", 2010, 2, "C3", 4500.50);
            voit2.afficher();
            voit2.setPrix(4000.00);
            Voiture voit3 = new Voiture(numero, annee, marque, modele, prix);
            voit3.afficher();
            monGarage.Add(voit1);
            monGarage.Add(voit2);
            Console.WriteLine();
            
            foreach (Voiture voit in monGarage)
            {
                voit1.afficher();
                Console.WriteLine("L'age de la voiture est " + voit.calculAge());
                Console.WriteLine("Le modèle de la voiture est " + voit.getModele());
                Console.WriteLine("La marque de la voiture est " + voit.getMarque());
            }

            Console.WriteLine("Tapez l'immatriculation de la voiture pour la supprimer");
            immat = Console.ReadLine();
            foreach (Voiture voit in monGarage)
            {
                if (voit.getNumero() == immat)
                {
                    plaque = true;
                }

                if (plaque == true)
                {
                    monGarage.Remove(voit);
                }
            }

            int i;
            i = 0;
            
            for (i = 0; i < monGarage.Count; i++)
            {
                monGarage[i].afficher();
                Console.WriteLine("L'age de la voiture est " + monGarage[i].calculAge());
                Console.WriteLine("Le modèle de la voiture est " + monGarage[i].getModele());
                Console.WriteLine("La marque de la voiture est " + monGarage[i].getMarque());
            }
            Console.ReadLine();
        }
    }
}
