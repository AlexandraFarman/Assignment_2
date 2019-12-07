﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomesForSales.Models
{
    public class Apartment : Residential
    {
        public Apartment(LegalForm legalForm, Address address, string estateId) : base(estateId, legalForm, address)
        {

        }

        public Apartment() { }
    }
}
