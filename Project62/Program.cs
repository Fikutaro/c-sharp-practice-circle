using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MinMax c = new MinMax();
            //  円の半径を設定
            c.r = 4.0;
            Console.WriteLine("半径" + c.r + "の円の円周の長さは" + c.Circumference());
            Console.WriteLine("半径" + c.r + "の円の面積は" + c.Area());
        }
    }
}