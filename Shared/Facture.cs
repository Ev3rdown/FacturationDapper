using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public class Facture
    {
        public Facture(string num,string nomC,DateTime emis,DateTime attendu,double du,double regle=0)
        {
            NumeroFacture = num;
            NomClient = nomC;
            DateEmission = emis;
            DateAttenduReglement = attendu;
            MontantDu = du;
            MontantRegle = regle;
        }
        public string NumeroFacture { get; }
        public string NomClient { get; }
        public DateTime DateEmission { get; }
        public DateTime DateAttenduReglement { get; }
        public double MontantDu { get; }
        public double MontantRegle { get; }
    }
}
