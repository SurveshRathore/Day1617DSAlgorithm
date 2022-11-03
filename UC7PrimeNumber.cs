using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1617Algorithm
{
    internal class UC7PrimeNumber
    {
        public void generatePrimeNum()
        {
            Console.WriteLine("The prime numbers from 0 to 1000 is: \n2");
            bool prime = false;
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                    else
                    {
                        prime = true;
                    }
                }
                if(prime)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
