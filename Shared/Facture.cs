using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public class Facture
    {
        public string NumeroFacture;
        public string NomClient;
        public DateTime DateEmission;
        public DateTime DateAttenduReglement;
        public double MontantDu;
        public double MontantRegle;
        public Facture(string num,string nomC,DateTime emis,DateTime attendu,double du,double regle=0)
        {
            NumeroFacture = num;
            NomClient = nomC;
            DateEmission = emis;
            DateAttenduReglement = attendu;
            MontantDu = du;
            MontantRegle = regle;
        }
    }
}
