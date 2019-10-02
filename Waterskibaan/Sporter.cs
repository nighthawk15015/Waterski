﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    class Sporter
    {
        private readonly Random random = new Random();
        public int _aantalPT;
        public int AantalRondenNogTeGaan { get;set;}
        public Zwemvest Zwemvest{ get; set;}
        public Skies Skies { get; set; }
        public Color KledingKleur { get; set; }
        public List<IMoves> Moves { get; set; }

        public Sporter(List<IMoves> moves)
        {
            foreach (IMoves m in moves)
            {
                _aantalPT +=  m.Moves();
            }
            Color randomkleur = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            KledingKleur = randomkleur;
            Moves = moves;
        }


    }
}
