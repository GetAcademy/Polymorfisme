using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfisme
{
    class CombustionCloset : ICloset, IIgniteable
    {
        public void Flush()
        {
            Console.WriteLine("Flushing CombustionCloset");
            Console.WriteLine(" - wrap");
            Ignite();
        }

        public void Ignite()
        {
            Console.WriteLine(" - ignite");
        }
    }
}
