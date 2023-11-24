using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class SmartphoneFactory: TechProductFactory
    {
        public override Screen CreateScreen()
        {
            return new SmartphoneScreen();
        }

        public override Processor CreateProcessor()
        {
            return new SmartphoneProcessor();
        }

        public override Camera CreateCamera()
        {
            return new SmartphoneCamera();
        }
    }
}
