using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Each new term in the Fibonacci sequence is generated
            //  by adding the previous two terms.By starting with
            //  1 and 2, the first 10 terms will be:
            //  1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

            //By considering the terms in the Fibonacci sequence 
            //whose values do not exceed four million, 
            //find the sum of the even-valued terms.

            int num1 = 0, num2 = 1, sum;
            
            for (int i = 1; i <= 10; i++)
            {
                sum = num1 + num2;
                Console.WriteLine(sum);
                num1 = num2;
                num2 = sum;
            }

        }
    }
}
