using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Controllers
{
    public interface IAddressController
    {
        bool AddAddress(string street, string city, string zipCode, string country);
    }
}
