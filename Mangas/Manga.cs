using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d1_tp4
{
    class Manga
    {
        private string titre;
        private string auteur;
        private string editeur;
        private double prix;
        private int nbPages;
        private int nbExemplaires;

        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }
        public string Auteur
        {
            get { return auteur; }
            set { auteur = value; }
        }
        public string Editeur
        {
            get { return editeur; }
            set { editeur = value; }
        }
        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }
        public int NbPages
        {
            get { return nbPages; }
            set { nbPages = value; }
        }
        public int NbExemplaires
        {
            get { return nbExemplaires; }
            set { nbExemplaires = value; }
        }

        public Manga()
        {
            this.Titre = "";
            this.Auteur = "";
            this.Editeur = "";
            this.Prix = 0.0;
            this.NbPages = 0;
            this.nbExemplaires= 0;
        }

        public Manga(string titre, 
                    string auteur, 
                    double prix)
        {
            this.Titre = titre;
            this.Auteur = auteur;
            this.Prix = prix;
        }

        public void NouvelExemplaire() => this.NbExemplaires++;
        public void NouvelExemplaire(int nbNouvel) => this.NbExemplaires += nbNouvel;
        public void PerteExemplaire()
        {
            if(this.nbExemplaires > 0)
            {
                this .NbExemplaires--;
            }
        }
        public void PerteExemplaire(int nbPerte) => this.NbExemplaires -= nbPerte;
        public bool EstPresent() => this.NbExemplaires >= 1 ? true : false;

        public string VoirPresence() => this.EstPresent() ?
                                    $"Le Manga '{this.Titre}' est disponible. " :
                                    $"Le manga '{this.Titre}' n'est pas disponible";
        public string VoirEgualite(Manga m) => this.Equals(m) ? 
                                    $"Le Manga '{this.Titre}' et le Manga '{m.titre}' " +
                                    $"sont pareils. " :
                                    $"Le manga '{this.Titre}' et le Manga '{m.titre}' " +
                                    $"ne sont pas pareils";
        public bool Equals(Manga m) => this.Titre == m.Titre &&
                                    this.Auteur == m.Auteur &&
                                    this.Editeur == m.Editeur;

        public void NouvelEditeur(string unEditeur) => this.Editeur = unEditeur;
        public string AfficherManga() => $"Le titre est : {this.Titre}\n" +
                                    $"L'auteur est : {this.Auteur}\n" +
                                    $"Le Nombre de pages est : {this.NbPages}\n" +
                                    $"L'editeur est : {this.Editeur}\n" +
                                    $"Le prix est : {this.Prix} euros \n" +
                                    $"Le nombre d'exemplaires est : {this.NbExemplaires}\n";
    }
}
