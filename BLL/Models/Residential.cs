using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomesForSales.Models
{
    public abstract class Residential : Estate
    {
        public Residential(string estateId, LegalForm legalForm, Address address) : base(estateId, legalForm, address)
        {
           
        }
    }
}
