using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public interface IBusinessData 
    {
        IEnumerable<Facture> Factures { get; }
        Tuple<double, double> CalculerTotalAttenduEtReel();
        Tuple<double,double> CalculerTotalAttenduEtReel(int mois,int annee);
        void Add(Facture facture);

    }
}
