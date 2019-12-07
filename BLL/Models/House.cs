using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomesForSales.Models
{
    public class House : Residential
    {
        public House(LegalForm legalForm, Address address, string estateId) : base(estateId, legalForm, address)
        {

        }

        public House() { }
    }
}
