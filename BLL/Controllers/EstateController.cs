using HomesForSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Controllers
{
    public class EstateController : IEstateController
    {
        public List<Estate> GetEstateTypes()
        {
            var estateTypes = new List<Estate>();
            estateTypes.Add(new Apartment());
            estateTypes.Add(new House());
            estateTypes.Add(new Shop());
            estateTypes.Add(new Townhouse());
            estateTypes.Add(new Warehouse());
            estateTypes.Add(new Villa());

            return estateTypes;
        }

        public bool AddEstate(Estate estate)
        {
            return true;
        }

        public bool UpdateEstate(Estate estate)
        {
            return true;
        }

        public bool DeleteEstate(Estate estate)
        {
            return true;
        }

        public bool SearchEstate(Estate estate)
        {
            return true;
        }
    }
}
