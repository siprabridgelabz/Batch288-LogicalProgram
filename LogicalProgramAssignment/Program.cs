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
              

                Console.WriteLine("1-FibonacciSeries");
                Console.WriteLine("2-Perfect Number");
                Console.WriteLine("3-Prime Number");


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
                        case 2:
                            Console.WriteLine("Perfect Number Program");
                           PerfectNumber perfectNumber=new PerfectNumber();
                            perfectNumber.Numbers();
                            break;
                        case 3:
                            Console.WriteLine("Prime Number Program");
                            PrimeNumber prime = new PrimeNumber();
                            prime.Number();
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
