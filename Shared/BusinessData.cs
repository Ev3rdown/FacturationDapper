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
                new Facture("f1","Gerbaud",new DateTime(2020,10,3),new DateTime(2021,01,03),201552),
                new Facture("f2","Arnaud",new DateTime(2020,11,15),new DateTime(2020,12,21),4200,500),
                new Facture("f3","Amanda",new DateTime(2020,11,18),new DateTime(2020,12,26),14200,11250),
                new Facture("f4","Axel",new DateTime(2020,11,26),new DateTime(2020,12,29),400,0),
                new Facture("f5","Antony",new DateTime(2020,11,30),new DateTime(2020,12,31),3088,3070),
            };

        }
        public double CalculerTotalAttendu()
        {
            double totalAttendu=0;
            foreach (var facture in Factures) totalAttendu += facture.MontantDu;    
            return totalAttendu;
        }
        public double CalculerTotalReel()
        {
            double totalReel = 0;
            foreach (var facture in Factures) totalReel += facture.MontantRegle;
            return totalReel;
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

