using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitati_Biblioteca
{
    public enum StareCarte
    {
        Noua=1,
        Intacta=2,
        Deteriorata = 3
    };

    [Flags]
    public enum ElementeComponenteCarte
    {
        Prefata=1,
        Postfata=2,
        Ilustratii=3,
        Introducere=4
    };

    public enum CampuriCarte
    {
        NUMAR_CARTI = 0,
        NUME_CARTE = 1,
        NUME_AUTOR = 2,
        EDITURA = 3,
        COTA = 4,
        STARE_CARTE = 5,
        ELEMENTE_COMPONENTE_CARTE = 6
    };
}
