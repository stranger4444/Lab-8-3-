using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class TabletFactory:TechProductFactory
    {
        public override Screen CreateScreen()
        {
            return new TabletScreen();
        }

        public override Processor CreateProcessor()
        {
            return new TabletProcessor();
        }

        public override Camera CreateCamera()
        {
            return new TabletCamera();
        }
    }
}
