using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation.Shared
{
    public class Dashboard
    {
        public double TotalAttendu { get; }
        public double TotalReel { get; }
        public Dashboard(double totalAttendu,double totalReel)
        {
            TotalAttendu = totalAttendu;
            TotalReel = totalReel;
        }
    }
}
