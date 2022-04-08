using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComputation
{
    internal class Compare
    {
        public static void CompareLength()
        {
            Console.WriteLine("Enter the value of x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));

            Console.WriteLine("Enter the value of a1");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of a2");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of c1");
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of c2");
            int c2 = Convert.ToInt32(Console.ReadLine());

            double length1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("The length of the line" + length1);

            double length2 = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((c2 - c1), 2));
            Console.WriteLine("The length of the line" + length2);

            int compare_value = length1.CompareTo(length2);

            if (compare_value == 0)
            {
                Console.WriteLine("Both the lines are equal\n\n");
            }
            else if (compare_value < 0)
            {
                Console.WriteLine("First line is leesthan second line\n\n");
            }
            else if (compare_value > 0)
            {
                Console.WriteLine("First line is graterthan second line\n\n");
            }
            Console.ReadLine();

        }
    }
}
