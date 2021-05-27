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
    public class Administrare_Biblioteca : IStocareData_Biblioteca
    {
        string NumeFisier { get; set; }

        public Administrare_Biblioteca(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();
        }

        public List<Carte> GetCarti()
        {
            List<Carte> carti = new List<Carte>();

            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;

                //citeste cate o linie si creaza un obiect de tip Carte pe baza datelor din linia citita
                while ((line = sr.ReadLine()) != null)
                {
                    Carte studentDinFisier = new Carte(line);
                    carti.Add(studentDinFisier);
                }
            }

            return carti;
        }

        public Carte GetCarte(string _nume_carte, string _nume_autor)
        {


            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;
                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                while ((line = sr.ReadLine()) != null)
                {
                    Carte carte = new Carte(line);
                    if (carte.nume_carte == _nume_carte && carte.nume_autor == _nume_autor)
                        return carte;
                }
            }

            return null;
        }

        public Carte GetCarte(int index)
        {


            using (StreamReader sr = new StreamReader(NumeFisier))
            {
                string line;
                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                while ((line = sr.ReadLine()) != null)
                {
                    Carte carte = new Carte(line);
                    if (carte.cota==index)
                        return carte;
                }
            }

            return null;
        }

        public bool UpdateCarti(Carte carteActualizata)
        {
            List<Carte> carti = GetCarti();
            bool actualizareCuSucces = false;
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Carte c in carti)
                    {
                        Carte cartePentruScrisInFisier = c;
                        //informatiile despre studentul actualizat vor fi preluate din parametrul "studentActualizat"
                        if (c.cota == carteActualizata.cota)
                        {
                            cartePentruScrisInFisier = carteActualizata;
                        }
                        swFisierText.WriteLine(cartePentruScrisInFisier.ConversieLaSir_PentruScriereInFisier());
                    }
                    actualizareCuSucces = true;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return actualizareCuSucces;

        }

        public void AddCarte(Carte c)
        {
            //instructiunea 'using' va apela la final swFisierText.Close();
            //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
            using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
            {
                swFisierText.WriteLine(c.ConversieLaSir_PentruScriereInFisier());
            }
        }
    }
}
