﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class SmartphoneCamera:Camera
    {
        public override void Capture()
        {
            Console.WriteLine("Smartphone camera is capturing");
        }
    }
}
