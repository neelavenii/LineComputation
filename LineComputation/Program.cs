using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line computation Program");
            Length length = new Length();
            Length.CalculateLength();
            Compare compare = new Compare();
            Compare.CompareLength();
            Console.ReadLine();
        }
    }
}
