using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d1_tp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Manga manga = new Manga("Dragon Ball","Akira Toriyama",15.0);
            Manga manga2 = new Manga("Gunnm (Berserk)","Ykito Kishiro",15.0);
            Console.WriteLine("INITIATION");
            Console.WriteLine(manga.AfficherManga());
            Console.WriteLine(manga.VoirPresence());
            manga.Prix = 12.5;
            manga.Editeur = "Gléant";
            manga.NbExemplaires = 12;
            manga.NbPages = 200;

            Console.WriteLine("________________Modifications__________________");
            Console.WriteLine(manga.AfficherManga());
            manga.NouvelEditeur("MangEdi");
            Console.WriteLine("________________Modifcation de l'editeur__________________");
            Console.WriteLine(manga.AfficherManga());
            Console.WriteLine(manga.VoirPresence());
            Console.WriteLine(manga.VoirEgualite(manga2));
        }
    }
}
