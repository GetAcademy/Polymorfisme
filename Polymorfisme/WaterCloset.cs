using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfisme
{
    class WaterCloset : ICloset
    {
        public void Flush()
        {
            Console.WriteLine("Flushing WaterCloset");
            Console.WriteLine(" - tømme vanntank");
            Console.WriteLine(" - starter ny fylling av vanntank");
        }
    }
}
