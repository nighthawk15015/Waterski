﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    interface IWachtrij
    {
        void SporterNeemPlaatsInRIj(Sporter sporter);
        List<Sporter> GetAlleSporters();
        List<Sporter> SportersVerlatenRij(int aantal);
    }
}
