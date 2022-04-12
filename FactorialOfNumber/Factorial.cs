using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialOfNumber
{
    public class Factorial
    {
        public void FindFactorial()
        {
            int i, result = 1 ;
            Console.WriteLine("Enter any number:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                result = result * i;
            }
            Console.WriteLine("Factorial of given number :" + result);
        }
    }
}
