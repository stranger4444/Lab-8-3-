using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class LaptopFactory:TechProductFactory
    {
        public override Screen CreateScreen()
        {
            return new LaptopScreen();
        }

        public override Processor CreateProcessor()
        {
            return new LaptopProcessor();
        }

        public override Camera CreateCamera()
        {
            return new LaptopCamera();
        }
    }
}
