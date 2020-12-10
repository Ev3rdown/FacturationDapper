using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public interface IBusinessData 
    {
        public IEnumerable<Facture> Factures { get; }
        public Tuple<double, double> CalculerTotalAttenduEtReel();
        public Tuple<double,double> CalculerTotalAttenduEtReel(int mois,int annee);


    }
}
