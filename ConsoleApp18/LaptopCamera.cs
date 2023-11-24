using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class LaptopCamera:Camera
    {
        public override void Capture()
        {
            Console.WriteLine("Laptop camera is capturing");
        }
    }
}
