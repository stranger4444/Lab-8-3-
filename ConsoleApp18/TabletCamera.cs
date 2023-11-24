using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class TabletCamera:Camera
    {
        public override void Capture()
        {
            Console.WriteLine("Tablet camera is capturing");
        }
    }
}
