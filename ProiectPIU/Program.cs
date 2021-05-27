//using Entitati_Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Memorare_Date;

namespace Entitati_Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList carti;
            ArrayList beneficiari;

            //creare fisiere txt

            IStocareData_Biblioteca administrareCarti = new Administrare_Biblioteca("Carti.txt");
            IStocareDate_Beneficiar administrareBeneficiar = new Administrare_Beneficiar("Beneficiari.txt");

            carti = administrareCarti.GetCarti();
            int nrCarti = carti.Count;
            //Carte.numar_ultima_carte = nrCarti;

            beneficiari = administrareBeneficiar.GetBeneficiari();
            int nrBeneficiari = beneficiari.Count;
            Beneficiar.id_ultim_beneficiar = nrBeneficiari;

            string optiune;
            do
            {
                Console.WriteLine("1. Afisare carti");
                Console.WriteLine("2. Creare si adaugare carte");
                Console.WriteLine("3. Gasire carte");
                Console.WriteLine("4. Inlocuire numar exemplare ale unei carti existente");
                Console.WriteLine("5. Afisare beneficiari existenti");
                Console.WriteLine("6. Inregistrare beneficiar");
                Console.WriteLine("7. Cautare beneficiar existent");
                Console.WriteLine("8. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "1":
                        AfisareCarti(carti);
                        break;
                    case "2":
                        Carte CarteTastatura = CitireCarte_Prin_parametri();
                        carti.Add(CarteTastatura);
                        //adaugare carte in fisier
                        administrareCarti.AddCarte(CarteTastatura);
                        break;
                    case "3"://cautrare carte posibil existenta in fisier
                        string _nume_carte, _nume_autor ;
                        Carte raspuns;

                        Console.WriteLine("Introduceti numele cartii cautate:");
                        _nume_carte = Console.ReadLine();
                        Console.WriteLine("Introduceti autorul cartii cautate:");
                        _nume_autor= Console.ReadLine();

                        raspuns = administrareCarti.GetCarte(_nume_carte,_nume_autor);

                        if (raspuns != null)
                        {
                            Console.Write("_____");
                            Console.Write(raspuns.Afisare_carte());
                            Console.WriteLine("_____");
                        }
                        else
                            Console.WriteLine("Cartea nu a fost gasita");
                        break;
                    case "4"://actualizare numar exemplare al unei carti existente
                        Carte CarteActualizata = CitireCarte_Prin_parametri();
                        bool confirmare;
                        confirmare = administrareCarti.UpdateNumarCarti(CarteActualizata);

                        if (confirmare)
                        {
                            carti = administrareCarti.GetCarti();
                            AfisareCarti(carti);
                        }
                        else
                            Console.WriteLine("Fisierul nu a putut fi actualizat deoarece cartea introdusa nu este existenta!");
                        break;
                    case "5":
                        AfisareBeneficiari(beneficiari);
                        break;
                    case "6":
                        Beneficiar BeneficiarTastatura = CitireBeneficiar_Prin_parametri();
                        beneficiari.Add(BeneficiarTastatura);
                        //adaugare beneficiar in fisier
                        administrareBeneficiar.AddBeneficiar(BeneficiarTastatura);
                        break;
                    case "7"://cautare beneficiar posibil existent in fisier
                        string _nume_beneficiar, _prenume_beneficiar, _CNP;
                        Beneficiar cautare;

                        Console.WriteLine("Introduceti numele beneficiarului cautat:");
                        _nume_beneficiar = Console.ReadLine();
                        Console.WriteLine("Introduceti prenumele beneficiarului cautat:");
                        _prenume_beneficiar = Console.ReadLine();
                        Console.WriteLine("Introduceti CNP-ul beneficiarului cautat:");
                        _CNP = Console.ReadLine();

                        cautare = administrareBeneficiar.GetBeneficiar(_nume_beneficiar, _prenume_beneficiar, _CNP);

                        if (cautare != null)
                        {
                            Console.Write("_____");
                            Console.Write(cautare.Afisare_beneficiar());
                            Console.WriteLine("_____");
                        }
                        else
                            Console.WriteLine("Cartea nu a fost gasita");
                        break;
                    case "8":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (true);
        }

        public static void AfisareCarti(ArrayList carti)
        {
            Console.WriteLine("Cartile sunt:");
            for (int i = 0; i < carti.Count; i++)
            {
                Console.WriteLine(((Carte)carti[i]).Afisare_carte());
            }
        }

        public static void AfisareBeneficiari(ArrayList beneficiari)
        {
            Console.WriteLine("Studentii sunt:");
            for (int i = 0; i < beneficiari.Count; i++)
            {
                Console.WriteLine(((Beneficiar)beneficiari[i]).Afisare_beneficiar());
            }
        }

        /*public static Carte CitireCarte_Un_singur_sir()
        {
            string sir;

            Console.WriteLine("Introduceti datele cartii pe care doriti sa o adaugati in urmatorul format:");
            Console.WriteLine("\t-nume carte");
            Console.WriteLine("\t-nume autor");
            Console.WriteLine("\t-nume editura");
            Console.WriteLine("\tnumar exemplare");
            Console.WriteLine("aceste campuri vor fi separate prin virgula.");
            Console.WriteLine("Daca nu veti respecta conditiile anterioare adaugarea nu va fi finalizata");

            sir = Console.ReadLine();

            Carte carte1 = new Carte(sir);

            for (int val = 0; val < 3; val++)
                Console.WriteLine("{0,3} - {1:C}", val, (StareCarte)val);
            int ok = 0;
            do
            {
                int optiune = Convert.ToInt32(Console.ReadLine());
                if (optiune >= 1 && optiune <= 3)
                {
                    carte1.stare_carte = Convert.ToString((StareCarte)optiune);
                    ok = 1;
                }
                else
                    Console.WriteLine("Specializarea introdusa nu corespunde celor disponibile");
            } while (ok == 0);

            for (int val = 0; val < 3; val++)
                Console.WriteLine("{0,3} - {1:C}", val, (ElementeComponenteCarte)val);
            int ok1 = 0;
            do
            {
                int optiune = Convert.ToInt32(Console.ReadLine());
                if (optiune >= 1 && optiune <= 3)
                {
                    carte1.stare_carte = Convert.ToString((ElementeComponenteCarte)optiune);
                    ok = 1;
                }
                else
                    Console.WriteLine("Specializarea introdusa nu corespunde celor disponibile");
            } while (ok1 == 0);
            //afisare = carte1.Afisare_carte();
            //Console.WriteLine(afisare);

            return carte1;
        }*/

        public static Carte CitireCarte_Prin_parametri()
        {
            string titlu, autor, editura;
            int numar;

            Console.WriteLine("\nIntroduceti datele cartii pe care doriti sa o adaugati camp cu camp:");
            Console.WriteLine("\t-nume carte");
            titlu = Console.ReadLine();
            Console.WriteLine("\t-nume autor");
            autor = Console.ReadLine();
            Console.WriteLine("\t-nume editura");
            editura = Console.ReadLine();
            
            int optiune1, optiune2;
            Console.WriteLine("\nStare carte introdusa:");
            Console.WriteLine("\t1.Noua");
            Console.WriteLine("\t2.Intacta");
            Console.WriteLine("\t3.Deteriorata");
            Console.Write("Alegeti o optiune: ");
            int ok = 0;
            do
            {
                optiune1 = Convert.ToInt32(Console.ReadLine());
                if (optiune1 >= 1 && optiune1 <= 3)
                {
                    ok = 1;
                }
                else
                {
                    Console.WriteLine("Specializarea introdusa nu corespunde celor disponibile");
                    Console.Write("Alegeti o optiune: ");
                }
                } while (ok == 0);

            Console.WriteLine("\nElementele componente ale cartii introduse:");
            Console.WriteLine("\t1.Prefata");
            Console.WriteLine("\t2.Postfata");
            Console.WriteLine("\t3.Ilustratii");
            Console.WriteLine("\t4.Introducere");
            Console.Write("Alegeti o optiune: ");
            int ok1 = 0;
            do
            {
                optiune2 = Convert.ToInt32(Console.ReadLine());
                if (optiune2 >= 1 && optiune2 <= 4)
                {
                    ok1 = 1;
                }
                else
                {
                    Console.WriteLine("Specializarea introdusa nu corespunde celor disponibile");
                    Console.Write("Alegeti o optiune: ");
                }

                } while (ok1 == 0);

            //afisare = carte2.Afisare_carte();
            //Console.WriteLine(afisare);

            //Carte carte2 = new Carte(titlu, autor, editura, Convert.ToString((StareCarte)optiune1), Convert.ToString((ElementeComponenteCarte)optiune2));

            //return carte2;
            return null;
        }

        /*public static Beneficiar CitireBeneficiar_Un_singur_sir()
        {
            string sir;

            Console.WriteLine("\nIntroduceti datele beneficiarului pe care doriti sa il adaugati in urmatorul format:");
            Console.WriteLine("\t-nume beneficiar");
            Console.WriteLine("\t-prenume beneficiar");
            Console.WriteLine("\t-CNP (13numere)");
            Console.WriteLine("aceste campuri vor fi separate prin virgula.");
            Console.WriteLine("Daca nu veti respecta conditiile anterioare adaugarea nu va fi finalizata");

            sir = Console.ReadLine();

            Beneficiar beneficiar1 = new Beneficiar(sir);
            //afisare = beneficiar1.Afisare_beneficiar();
            //Console.WriteLine(afisare);

            return beneficiar1;
        }*/

        public static Beneficiar CitireBeneficiar_Prin_parametri()
        {
            string nume, prenume, CNP;

            Console.WriteLine("\nIntroduceti datele cartii pe care doriti sa o adaugati camp cu camp:");
            Console.WriteLine("\t-nume beneficiar");
            nume = Console.ReadLine();
            Console.WriteLine("\t-prenume beneficiar");
            prenume = Console.ReadLine();
            do
            {
                Console.WriteLine("\t-CNP (13numere)");
                CNP = Console.ReadLine();
                if (CNP.Length != 13)
                    Console.WriteLine("Ati introdus incorect");
            } while (CNP.Length != 13);
            
            Beneficiar beneficiar2 = new Beneficiar(nume, prenume, CNP);

            //afisare = beneficiar2.Afisare_beneficiar();
            //Console.WriteLine(afisare);

            return beneficiar2;
        }
    }
}
