using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionalAlgorithmsExample.Core
{
    internal class TestFunction
    {


        public static int Sensivity { get; } = 1000;



        // NO 9
        /*
        public static GenomeSchema XSchema { get; } = new GenomeSchema(variableName:"X", min:-10, max:10);
        public static GenomeSchema YSchema { get; } = new GenomeSchema(variableName: "Y", min: -10, max: 10);

        public static GenomeSchema[] genomeSchemas = new GenomeSchema[] { XSchema, YSchema };

        public static double Eval(Genome p)
        {
            double x = p.nucleotides[0].Value;
            double y = p.nucleotides[1].Value;
            return Math.Pow(Math.Sin(3 * Math.PI * x), 2) + (Math.Pow((x - 1), 2) * (1 + (Math.Pow(Math.Sin(3 * Math.PI * y), 2)))) + ((Math.Pow(y - 1, 2)) * (1 + (Math.Pow(Math.Sin(2 * Math.PI * y), 2))));
        }
         */


        // NO 7
        /*
        public static GenomeSchema XSchema { get; } = new GenomeSchema(variableName: "X", min: -15, max: 5);
        public static GenomeSchema YSchema { get; } = new GenomeSchema(variableName: "Y", min: -3, max: 3);

        public static GenomeSchema[] genomeSchemas = new GenomeSchema[] { XSchema, YSchema };

        public static double Eval(Genome p) // Statik olarak işaretlendi
        {
            double x = p.nucleotides[0].Value;
            double y = p.nucleotides[1].Value;

            double part1 = 100.0 * (Math.Sqrt(Math.Abs(y - (0.01 * Math.Pow(x, 2)))));
            double part2 = (0.01 * (Math.Abs(x + 10)));
            double result = part1 + part2;

            return result;
        }
        */


        // No 0

        public static GenomeSchema XSchema { get; } = new GenomeSchema(variableName: "X", min: -5, max: 5);
        public static GenomeSchema YSchema { get; } = new GenomeSchema(variableName: "Y", min: -5, max: 5);

        public static GenomeSchema[] genomeSchemas = new GenomeSchema[] { XSchema, YSchema };

        public static double Eval(Genome p) // Statik olarak işaretlendi
        {
            double x = p.nucleotides[0].Value;
            double y = p.nucleotides[1].Value;


            return (2 * Math.Pow(x, 2) - (1.05 * Math.Pow(x, 4))  + (Math.Pow(x,6)/6.0) + (x * y) + (Math.Pow(y,2)));
        }



    }
}
