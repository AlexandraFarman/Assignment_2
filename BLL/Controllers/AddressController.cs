using HomesForSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Controllers
{
    public class AddressController : IAddressController
    {
        public bool AddAddress(Address address)
        {
            return true;
        }

        public bool UpdateAddress(Address address)
        {
            return true;
        }

        public bool DeleteAddress(Address address)
        {
            return true;
        }
        public bool SearchAddress(Address address)
        {
            return true;
        }
    }
}
