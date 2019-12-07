using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Controllers
{
    public interface IApartmentController
    {
        bool AddApartment(string etstateId, string legalForm, string address);
    }
}
