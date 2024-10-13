﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarzCo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Volvo", "XC", 2004, 3425);
            Motorbike motorbike = new Motorbike("Harley", "MN", 1996, 8393);
            Bicycle bicycle = new Bicycle("Kseniias", "NM", 2006, 3930, 4);


            car.Drive();
            car.ThisVechile();

            motorbike.Drive();
            motorbike.ThisVechile();

            bicycle.Drive();
            bicycle.ThisVechile();
        }

    }
}
