using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitati_Biblioteca
{
    public class Carte
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ',';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        public const int NR_MAXIM_IMPRUMUTURI = 5;
        public const int DISPONIBIL = 1;

        private const int NUMAR_CARTI = 0;
        private const int NUME_CARTE = 1;
        private const int NUME_AUTOR = 2;
        private const int EDITURA = 3;
        private const int COTA = 4;
        private const int STARE_CARTE= 5;
        private const int ELEMENTE_COMPONENTE_CARTE = 6;

        //proprietati
        public string nume_carte { get; set; } 
        public string nume_autor { get; set; } 
        public string editura { get; set; } 
        public int cota { get; set; } 
        public bool disponibilitate { get; set; } = true; 
        public static int numar_carti { get; set; } = 0; 
        public StareCarte stare_carte { get; set; } 
        public List<string> elemente_componnte_carte { get; set; } 

        //constructor implicit 

        public Carte()
        {
            nume_carte = nume_autor = editura = string.Empty;
            numar_carti++;
            cota = numar_carti;
        }

        //constructor cu un singur parametru
        public Carte(string carte)
        {
            string[] Carte = carte.Split(SEPARATOR_PRINCIPAL_FISIER);

            numar_carti = Convert.ToInt32(Carte[(int)CampuriCarte.NUMAR_CARTI]);
            nume_carte = Carte[(int)CampuriCarte.NUME_CARTE];
            nume_autor = Carte[(int)CampuriCarte.NUME_AUTOR];
            editura = Carte[(int)CampuriCarte.EDITURA];
            cota = numar_carti;
            stare_carte = (StareCarte)Convert.ToInt32(Carte[(int)CampuriCarte.STARE_CARTE]);

            elemente_componnte_carte = new List<string>();
            //adauga mai multe elemente in lista de discipline
            elemente_componnte_carte.AddRange(Carte[(int)CampuriCarte.ELEMENTE_COMPONENTE_CARTE].Split(SEPARATOR_SECUNDAR_FISIER));
            
        }

        //constructor cu parametri text
        public Carte(string _nume_carte, string _nume_autor, string _editura)
        {
            nume_carte = _nume_carte;
            nume_autor = _nume_autor;
            editura = _editura;
            numar_carti++;
            cota = numar_carti;
        }

        
        public string Afisare_carte()
        {
            if (nume_carte != string.Empty && nume_autor != string.Empty && editura != string.Empty && cota !=0)
            {
                string rezultat = $"Cartea {nume_carte} este scrisa de {nume_autor} si este publicata de editura {editura}, avea cota {cota}, in stare {stare_carte}, si avand {elemente_componnte_carte}";
                return rezultat;
            }
            else
            {
                string rezultat = $"\n Nu ati introdus datele corect, inregistrarea nu s-a finalizat";
                return rezultat;
            }
        }

        public string ConversieLaSir_PentruScriereInFisier()
        {
            string elemente = "";
            for (int i = 0; i < elemente_componnte_carte.Count; i++)
            {
                elemente += elemente_componnte_carte[i];
                elemente += " ";
            }
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}",
                SEPARATOR_PRINCIPAL_FISIER, cota.ToString(), (nume_carte ?? " NECUNOSCUT "), (nume_autor ?? " NECUNOSCUT "), (editura ?? " NECUNOSCUT "), cota.ToString(), Convert.ToInt32(stare_carte), elemente);

            return s;
        }

        ///VALIDARI
        public static bool Disponibilitate(int nr)
        {
            if (nr >= DISPONIBIL)
                return true;
            return false;
        }

        public static bool ValideazaImprumut(int nr)
        {
            if (nr < NR_MAXIM_IMPRUMUTURI)
                return true;
            return false;
        }
    }
}
