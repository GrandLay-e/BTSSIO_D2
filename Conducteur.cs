using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VtrConducteur
{
    class Conducteur
    {
        private string nom;
        private string prenom;
        private int numeroPermis;
        private DateTime dateNaissance;
        private Voiture voiture;

        public Conducteur()
        {
            this.Nom = "";
            this.Prenom = "";
            this.NumeroPermis = 0;
            this.DateNaissance = DateTime.Now;
            this.Voiture = new Voiture();
        }

        public Conducteur(string nom, string prenom, int nmPermis, DateTime dateNaiss, Voiture vtr)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.NumeroPermis = nmPermis;
            this.DateNaissance = dateNaiss;
            this.Voiture = vtr;
        }
        public Conducteur(string nom, string prenom, int nmPermis, DateTime dateNaiss)
        {
            this.Nom= nom;
            this.Prenom = prenom;
            this.NumeroPermis = nmPermis;
            this.DateNaissance = dateNaiss;
        }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }
        public int NumeroPermis
        {
            get { return this.numeroPermis; }
            set { this.numeroPermis = value; }
        }

        public DateTime DateNaissance
        {
            get { return this.dateNaissance; }
            set { this.dateNaissance = value; } 
        }

        public Voiture Voiture
        {
            get { return this.voiture; }
            set { this.voiture = value; }
        }

        public void ChangerVoiture(Voiture voiture)
        {
            this.Voiture = voiture;
            voiture.Conducteur = this;
        }

        public string InfosConducteur() => $"\nConducteur : \nNuméro de permis : {this.NumeroPermis}\n" +
            $"Nom et prenom : {this.Nom} {this.prenom}\n" +
            $"Date de naissance : {this.DateNaissance:d/M/yyyy}\n";
        
        public string Afficher()
        {
            string infos = this.InfosConducteur();
            if(this.Voiture != null)
            {
                infos += "\t^\n\t|"+this.Voiture.InfosVoiture();
            }
            return infos;
        }
    }
}
