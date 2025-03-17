using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionalAlgorithmsExample.Core
{
    internal class TestFunction
    {
        public static int VariableCount { get; } = 2;
        public static int Min { get; } = -10;
        public static int Max { get; } = 10;
        public static double Range { get; } = Max - Min;
        public static int Sensivity { get; } = 1000;

        public static int BitCount { get; } =  (int) Math.Ceiling(Math.Log((double)(Max - Min) * Sensivity, 2));


        public static double Eval(double x, double y)
         {
             return Math.Pow(Math.Sin(3 * Math.PI * x), 2) + (Math.Pow((x - 1), 2) * (1 + (Math.Pow(Math.Sin(3 * Math.PI * y), 2)))) + ( (Math.Pow(y-1,2)) * (1 + (Math.Pow(Math.Sin(2*Math.PI*y),2)))) ;
         }

       


    }
}
