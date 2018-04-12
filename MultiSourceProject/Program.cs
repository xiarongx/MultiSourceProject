using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evaluator;

namespace MultiSourceProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Eval eval = new Eval();
            string mathExpression = "2 * 3 + 4";
            var result = eval.Evaluate(mathExpression);

            Console.WriteLine("Next line uses a public nuget package from nuget.org.");
            Console.WriteLine("2 * 3 + 4 = " + result);

            ACReditPlus.TestLib1.returnString returnStringAP1 = new ACReditPlus.TestLib1.returnString();
            ACReditPlus.TestLib2.returnString returnStringAP2 = new ACReditPlus.TestLib2.returnString();
            Triad.TestLib1.returnString returnStringT1 = new Triad.TestLib1.returnString();
            Triad.TestLib2.returnString returnStringT2 = new Triad.TestLib2.returnString();

            Console.WriteLine(returnStringAP1.TimeAndLocation());
            Console.WriteLine(returnStringAP2.TimeAndLocation());
            Console.WriteLine(returnStringT1.TimeAndLocation());
            Console.WriteLine(returnStringT2.TimeAndLocation());

            Console.ReadLine();
        }
    }
}
