using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ForLoop10to1andsumof10
    {
        static void Main(string[] args)
        {
            int sum= 0;
            for (int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
                sum = sum + i;
            }
            Console.WriteLine("The sum of numbers from 1 to 10 is: " + sum);
        }
    }
}
