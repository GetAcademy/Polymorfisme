using System;
using Polymorfisme.Inheritance;

namespace Polymorfisme
{
    class Program
    {
        static void Main(string[] args)
        {
            var outdoorCloset = new OutdoorCloset();
            outdoorCloset.Flush();

            Console.WriteLine(outdoorCloset);
            //var closet1 = new WaterCloset();
            //var closet2 = new CombustionCloset();

            //closet1.Flush();
            //closet2.Flush();

            //var closets = new ICloset[] {
            //ICloset[] closets = {
            ICloset[] closets = new ICloset[] {
                new WaterCloset(), new CombustionCloset(), new CombustionCloset()
            };
            foreach (var closet in closets)
            {
                closet.Flush();
            }

            IIgniteable[] igniteables = new IIgniteable[]
            {
                new CombustionCloset()
            };
            foreach (var igniteable in igniteables)
            {
                igniteable.Ignite();
            }
        }
    }
}
