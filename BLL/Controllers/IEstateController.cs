using HomesForSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Controllers
{
    public interface IEstateController
    {
        List<Estate> GetEstateTypes();
        bool AddEstate(Estate estate);
        bool UpdateEstate(Estate estate);
        bool DeleteEstate(Estate estate);
        bool SearchEstate(Estate estate);
    }
}
