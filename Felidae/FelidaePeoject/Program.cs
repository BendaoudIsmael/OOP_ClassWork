﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelidaePeoject
{
    class Program
    {
        static void Main(string[] args)
        {
            Felidae cat1 = new Lion(false, 65);  //new Felidae();
            Felidae cat2 = new AfricanLion(male, 150);  //new Felidae(false);
            Felidae cat3 = new Lion(false, 200);  //new Felidae(true);

            Console.WriteLine("Car 1's gender is " + cat1.Male);
            Console.WriteLine("Car 2's gender is " + cat2.Male);
            Console.WriteLine("Car 3's gender is " + cat3.Male);

            Lion cat4 = new Lion(true, 200);
            Lion cat5 = new Lion(true, 180);

            Console.WriteLine("\nCat 4 is a Lion and it's gender is " + cat4.Male +
               " and weight is " + cat4.Weight);

            Console.WriteLine("Cat 5 is a Lion and it's gender is " + cat5.Male +
                " and weight is " + cat5.Weight);

            AfricanLion cat6 = new AfricanLion(false, 300);

            Console.WriteLine("\nOutputs for the ToString() method\n");
            Console.WriteLine(cat1.ToString());
            Console.WriteLine(cat5.ToString());
            Console.WriteLine(cat6.ToString());

            Console.ReadKey();
        }
    }
}
