using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public class BusinessData : IBusinessData
    {
        public IEnumerable<Facture> Factures { get; }
        public BusinessData()
        {
            Factures = new Facture[]
            {
                new Facture("Materiaux","Gerbaud",new DateTime(2020,10,3),new DateTime(2021,01,03),201552),
                new Facture("Equipement","Arnaud",new DateTime(2020,11,15),new DateTime(2020,12,21),4200,500),
            };

        }
    }
}
