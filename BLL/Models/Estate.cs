using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomesForSales.Models
{
    public abstract class Estate
    {
        public string EstateId { get; set; }
        private LegalForm LegalForm { get; set; }
        private Address Address { get; set; }

        public Estate(string estateId, LegalForm legalForm, Address address)
        {
            EstateId = estateId;
            LegalForm = legalForm;
            Address = address;

        }
    }
}
