﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Controllers
{
    public interface IHouseController
    {
        bool AddHouse(string etstateId, string legalForm, string address);
    }
}
