using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomesForSales.Models
{
   public class Address
    {
        private string Street { get; set; }
        private string ZipCode { get; set; }
        private string City { get; set; }
        private Countries Country { get; set; }

        public Address(string street, string zipCode, string city, Countries country)
        {
            Street = street;
            ZipCode = zipCode;
            City = city;
            Country = country;
        }
    }
}
