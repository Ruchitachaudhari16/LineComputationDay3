using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComputations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Computation Problem");
            LineComputations lineComputations = new LineComputations();
            lineComputations.LengthOfLine();
            Console.ReadLine();
        }
    }
}
