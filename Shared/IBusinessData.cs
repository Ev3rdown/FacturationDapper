using System;
using System.Collections.Generic;
using System.Text;

namespace Facturation.Shared
{
    public interface IBusinessData 
    {
        public IEnumerable<Facture> Factures { get; }
    }
}
