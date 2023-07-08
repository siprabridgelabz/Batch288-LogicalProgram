using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Logical Programs");

                Console.WriteLine("1-FibonacciSeries");
                {
                    Console.WriteLine("CHOOSE THE BELOW OPTIONS");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Fibonacci Series Program");
                            FibonacciSeries fibonacci = new FibonacciSeries();
                            fibonacci.Series();
                            break;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }
            }
        }
    }
}
