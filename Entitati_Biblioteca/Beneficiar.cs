using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitati_Biblioteca
{
    public class Beneficiar
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ',';

        private const int ID = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;
        private const int CNP_UL = 3;

        //proprietati
        public int id { get; set; } 
        public string nume { get; set; }
        public string prenume { get; set; }
        public string CNP { get; set; }
        public int numar_imprumutari { get; set; } = 0;
        public static int id_ultim_beneficiar { get; set; } = 0;

        //constructor implicit

        public Beneficiar()
        {
            nume = prenume = CNP = string.Empty;
            id_ultim_beneficiar++;
            id = id_ultim_beneficiar;
        }

        //constructor cu un singur parametru
        public Beneficiar(string beneficiar)
        {
            string[] Beneficiar = beneficiar.Split(',');

            /*if (Beneficiar.Length != 3)
                Console.WriteLine("ATENTIE!!! Nu ati introdus toate informatiile necesare introducerii unei carti");
            else
            {*/
                id = Convert.ToInt32(Beneficiar[ID]);
                nume = Beneficiar[NUME];
                prenume = Beneficiar[PRENUME];
                Beneficiar[CNP_UL] = Beneficiar[CNP_UL].Replace(" ", "");
                CNP = Beneficiar[CNP_UL];
                id_ultim_beneficiar = id;

                /*if (Validari.Verificare_CNP(CNP) == false)
                {
                    nume = prenume = CNP = string.Empty;
                    id_ultim_beneficiar++;
                    id = id_ultim_beneficiar;
                    Console.WriteLine("Atentie, CNP invalid!!!");
                }*/
            //}
        }

        //constructor cu mai multi parametri
        public Beneficiar(string _nume, string _prenume, string _CNP)
        {
            nume = _nume;
            prenume = _prenume;
            _CNP = _CNP.Replace(" ", "");
            /*if (Validari.Verificare_CNP(_CNP) == false)
            {
                nume = prenume = CNP = string.Empty;
                Console.WriteLine("Atentie, CNP invalid!!!");
            }
            else
            {*/
                CNP = _CNP;
            //}
            
        }

        //afisarea ultimei carti introduse
        public string Afisare_beneficiar()
        {
            if (nume != string.Empty && prenume != string.Empty && CNP != string.Empty)
            {
                string rezultat = $"\n{nume} {prenume} a fost introdus cu succes in baza de date cu id-ul unic {CNP}";
                return rezultat;
            }
            else
            {
                string rezultat = $"\n Nu ati introdus CNP-ul corect, inregistrarea nu s-a finalizat";
                return rezultat;
            }
        }

        public string ConversieLaSir_PentruScriereInFisier()
        {
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}",
                SEPARATOR_PRINCIPAL_FISIER, id.ToString(), (nume ?? " NECUNOSCUT "), (prenume ?? " NECUNOSCUT "), (CNP ?? " NECUNOSCUT "));

            return s;
        }
    }
}
