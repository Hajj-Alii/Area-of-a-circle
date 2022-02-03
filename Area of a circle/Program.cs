using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_a_circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius : ");
            string str = Console.ReadLine();

            Console.WriteLine($"Area : {Math.PI * Math.Pow(Convert.ToDouble(str), 2)}");

            Console.WriteLine("\n\nPress Enter To Exit");
            Console.ReadLine();
        }
    }
}
