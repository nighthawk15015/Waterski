﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    class Program
    {
        static void Main(string[]args)
        {
            TestOpdr2();
            TestOpdr3();
            TestOpdr8();

        }

        private static void TestOpdr2()
        {
            Kabel k = new Kabel();
            Lijn l1 = new Lijn();
            Lijn l2 = new Lijn();
            

            Console.WriteLine(k.IsStartPositieLeeg());
            k.NeemLijnInGebruik(l1);
            Console.WriteLine(k.ToString());
            k.VerschuifLijnen();

            Console.WriteLine(k.IsStartPositieLeeg());
            k.NeemLijnInGebruik(l2);
            Console.WriteLine(k.ToString());
            k.VerschuifLijnen();
            Console.WriteLine("--------------------------------------------- \n");
           
        }

        private static void TestOpdr3()
        {

            LijnenVoorraad voorraad = new LijnenVoorraad();
            Lijn l = new Lijn();
            Lijn k = new Lijn();
                    
            Console.WriteLine(voorraad.ToString());
            voorraad.LijnToevoegenAanRij(l);
            Console.WriteLine(voorraad.ToString());

            voorraad.LijnToevoegenAanRij(k);
            Console.WriteLine(voorraad.ToString());
        
            voorraad.VerwijderEersteLijn();
            Console.WriteLine(voorraad.ToString());

            Console.WriteLine("--------------------------------------------- \n");
        }

        private static void TestOpdr8()
        {
          
            Sporter s1 = new Sporter(MoveCollection.GetWillekeurigeMoves());
            Waterskibaan water = new Waterskibaan();        
            Skies skies = new Skies();
            Zwemvest zwemvest = new Zwemvest();
            s1.Zwemvest = zwemvest;
            s1.Skies = skies;
            water.SporterStart(s1);
        }



    }
}
