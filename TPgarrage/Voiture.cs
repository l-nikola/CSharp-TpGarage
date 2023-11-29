using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Xamarin.Forms;

namespace TPgarrage
{
    public class Voiture
    {
        private string _numero;
        private int _annee;
        private int _marque;
        private string _modele;
        private double _prix;
        //classes
        public Voiture (string numero, int annee, int marque, string modele, double prix)
        {
            _numero = numero;
            _annee = annee;
            _marque = marque;
            _modele = modele;
            _prix = prix;
        }
        //accensseur numéro
        public string getNumero()
        {
            return _numero;
        }
        //accensseur année
        public int getAnnee()
        {
            return _annee;
        }
        //accensseur marque
        public int getMarque()
        {
            return _marque;
        }
        //accensseur modèle
        public string getModele()
        {
            return _modele;
        }
        //accensseur prix
        public double getPrix()
        {
            return _prix;
        }
        //modification prix
        public void setPrix(double nouveauprix)
        {
            _prix = nouveauprix;
        }
        //calcul age 
        public int calculAge()
        {
            return (DateTime.Today.Year - _annee);
        }
        //affichage
        public void afficher()
        {
            Console.WriteLine("L'immatriculation est " + _numero);
            Console.WriteLine("Le modèle est " + _modele);
            Console.WriteLine("Le prix est " + _prix);
            Console.WriteLine("----------------------------");
        }
    }
}