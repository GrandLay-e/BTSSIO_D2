using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VtrConducteur
{
    class Voiture
    {
        private string numeroImmatriculation;
        private string marque;
        private string modele;
        private DateTime dateFabrication;
        private Conducteur conducteur;
        public Voiture()
        {
            this.numeroImmatriculation = "";
            this.marque = "";
            this.dateFabrication = DateTime.Now;
            this.conducteur = new Conducteur();
        }
        public Voiture(string im, string marque,string modele, DateTime dateFabrication, Conducteur conducteur)
        {
            this.NumeroImmatriculation = im;
            this.Marque = marque;
            this.Modele = modele;
            this.DateFabrication = dateFabrication;
            this.Conducteur = conducteur;
        }
        public Voiture(string im, string marque,string modele, DateTime dateFabrication)
        {
            this.NumeroImmatriculation = im;
            this.Marque = marque;
            this.Modele = modele;
            this.DateFabrication = dateFabrication;
        }

        public string NumeroImmatriculation
        {
            get { return numeroImmatriculation; }
            set { numeroImmatriculation = value; }
        }
        public string Marque
        {
            get {return this.marque;}
            set {this.marque = value;}
        }
        public string Modele
        {
            get {return this.modele;}
            set {this.modele = value;}
        }
        public DateTime DateFabrication
        {
            get { return this.dateFabrication; }
            set { this.dateFabrication = value; }
        }

        public Conducteur Conducteur
        {
            get { return this.conducteur; }
            set { this.conducteur = value; }
        }

        public void ChangerConducteur(Conducteur conducteur)
        {
            this.Conducteur = conducteur;
            conducteur.Voiture = this;
        }

        public string InfosVoiture() => $"\nMarque : {this.Marque}\n" +
            $"Modèle : {this.Modele}\n" +
            $"Matricule : {this.NumeroImmatriculation}\n" +
            $"Date Fabrication : {this.DateFabrication:d}\n";
        
        public string Afficher()
        {
            string infos = this.InfosVoiture();
            if(this.Conducteur != null)
            {
                infos += "\t^\n\t|" + this.Conducteur.InfosConducteur();
            }
            return infos;
        }
    }
}
