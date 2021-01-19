using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Facturation.Shared;
using Dapper;

namespace Facturation.Server.Models
{
    public class BusinessDataSql : IBusinessData,IDisposable
    {
        private SqlConnection cnct;
        public BusinessDataSql(string connectionString)
        {
            cnct = new SqlConnection(connectionString);
        }
        public void Dispose()
        {
            cnct.Close();
        }
        public IEnumerable<Facture> Factures => cnct.Query<Facture>("Select * from Factures ORDER BY DateAttenduReglement DESC");

        public Tuple<double, double> CalculerTotalAttenduEtReel()
        {
            Double attendu = cnct.ExecuteScalar<Double>("Select SUM(MontantDu) from Factures");
            Double regle = cnct.ExecuteScalar<Double>("Select SUM(MontantRegle) from Factures");
            return Tuple.Create(attendu, regle);
        }

        public Tuple<double, double> CalculerTotalAttenduEtReel(int mois, int annee)
        {
            Double v1 = 254;
            Double v2 = 298;
            return Tuple.Create(v1, v2);
            throw new NotImplementedException();
        }
        public void Add(Facture facture)
        {
            throw new NotImplementedException();
        }
    }
}
