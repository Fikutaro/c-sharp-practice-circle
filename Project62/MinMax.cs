using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_1
{
    //  最大値と最小値を求めるクラス
    class MinMax
    {
        //  半径
        public double r;
        //  円周の長さを求める
        public double Circumference()
        {
            return 2 * 3.14 * r;
        }

        public double Area()
        {
            return  3.14 * r * r;
        }
    }
}