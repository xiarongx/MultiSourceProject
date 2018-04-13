using ACReditPlus.TestLib1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiSourceProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This console app uses private NuGet package ACReditPlus.TestLib1");
            Console.WriteLine("Which has two dependencies: ACReditPlus.TestLib2 (private) and Evaluator (public)");

            ReturnString timeAndLocation = new ReturnString();

            Console.WriteLine(timeAndLocation.TimeAndLocation());

            Console.ReadLine();
        }
    }
}
