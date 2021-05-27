using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Entitati_Biblioteca;

namespace Memorare_Date
{
    public interface IStocareDate_Beneficiar
    {
        ArrayList GetBeneficiari();
        Beneficiar GetBeneficiar(string _nume_beneficiar, string _prenume_beneficiar, string _CNP);
        void AddBeneficiar(Beneficiar b);
        
    }
}
