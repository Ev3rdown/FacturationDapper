using System;
using System.Collections.Generic;

namespace Facturation.Shared
{
    public class BusinessData : IBusinessData
    {
        public IEnumerable<Facture> Factures { get; }
        public BusinessData()
        {
            Factures = new Facture[]
            {
                new Facture("f1","Gerbaud",new DateTime(2020,10,3),new DateTime(2021,01,03),201552),
                new Facture("f2","Arnaud",new DateTime(2020,11,15),new DateTime(2020,12,21),4200,500),
                new Facture("f3","Amanda",new DateTime(2020,11,18),new DateTime(2020,12,26),14200,11250),
                new Facture("f4","Axel",new DateTime(2020,11,26),new DateTime(2020,12,29),400,450),
                new Facture("f5","Antony",new DateTime(2020,11,30),new DateTime(2020,12,31),3088,3070),
                new Facture("f6","Gerbaud",new DateTime(2021,1,3),new DateTime(2021,1,13),201552),
                new Facture("f7","Arnaud",new DateTime(2021,1,15),new DateTime(2021,1,21),4200,500),
                new Facture("f8","Amanda",new DateTime(2021,1,18),new DateTime(2021,1,26),14200,11250),
                new Facture("f9","Axel",new DateTime(2021,1,22),new DateTime(2021,1,29),400,400),
                new Facture("f10","Antony",new DateTime(2021,1,30),new DateTime(2021,1,31),3088,3070),
            };

        }
        public Tuple<double, double> CalculerTotalAttenduEtReel()
        {
            double totalAttendu = 0;
            double totalReel = 0;
            
            foreach (var facture in Factures)
            {
                totalAttendu += facture.MontantDu;
                totalReel += facture.MontantRegle;            
            }
            return Tuple.Create(totalAttendu,totalReel);
        }
        public Tuple<double, double> CalculerTotalAttenduEtReel(int mois, int annee)
        {
            double totalAttendu = 0;
            double totalReel = 0;
            foreach (var facture in Factures)
            {
                if (facture.DateAttenduReglement.Year == DateTime.Today.Year && facture.DateAttenduReglement.Month == DateTime.Today.Month)
                {
                    totalAttendu += facture.MontantDu;
                    totalReel += facture.MontantRegle;
                }
            }
            return Tuple.Create(totalAttendu, totalReel);
        }
    }
}

