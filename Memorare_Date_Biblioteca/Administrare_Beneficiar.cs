using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using Entitati_Biblioteca;

namespace Memorare_Date
{
    public class Administrare_Beneficiar : IStocareDate_Beneficiar
    {
        string NumeFisier { get; set; }
        public Administrare_Beneficiar(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();
        }
        public ArrayList GetBeneficiari()
        {
            ArrayList beneficiar = new ArrayList();

            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;

                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                while ((line = sr.ReadLine()) != null)
                {
                    Beneficiar studentDinFisier = new Beneficiar(line);
                    beneficiar.Add(studentDinFisier);
                }
            }

            return beneficiar;
        }
        public Beneficiar GetBeneficiar(string _nume_beneficiar, string _prenume_beneficiar, string _CNP)
        {
            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;

                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                while ((line = sr.ReadLine()) != null)
                {
                    Beneficiar beneficiarDinFisier = new Beneficiar(line);
                    if (beneficiarDinFisier.nume == _nume_beneficiar && beneficiarDinFisier.prenume == _prenume_beneficiar && beneficiarDinFisier.CNP == _CNP)
                        return beneficiarDinFisier;

                }
            }

            return null;
        }
        public void AddBeneficiar(Beneficiar b)
        {
            //instructiunea 'using' va apela la final swFisierText.Close();
            //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
            using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
            {
                swFisierText.WriteLine(b.ConversieLaSir_PentruScriereInFisier());
            }
        }
    }
}
