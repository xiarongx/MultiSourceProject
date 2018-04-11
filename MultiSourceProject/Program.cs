using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateNugetMath;
using Evaluator;
namespace MultiSourceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass mathClass = new MathClass();
            Console.WriteLine("Next line uses private nuget package from dev server.");
            Console.WriteLine("5 times 5 equals: " + mathClass.multiplication(5, 5));

            Eval eval = new Eval();
            string mathExpression = "2 * 3 + 4";
            var result = eval.Evaluate(mathExpression);

            Console.WriteLine("Next line uses a public nuget package from nuget.org.");
            Console.WriteLine("2 * 3 + 4 = " + result);


            Console.ReadLine();
        }
    }
}
