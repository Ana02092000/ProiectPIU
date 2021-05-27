using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Entitati_Biblioteca;

namespace Memorare_Date
{
    public interface IStocareData_Biblioteca
    {
        List<Carte> GetCarti();
        Carte GetCarte(string nume_carte, string nume_autor);
        Carte GetCarte(int index);
        bool UpdateCarti(Carte carteActualizata);
        void AddCarte(Carte c);

        
    }
}
