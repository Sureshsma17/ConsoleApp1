//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Nested_CW
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter a number");
//            sbyte a = sbyte.Parse(Console.ReadLine());

//            switch (a > 0)
//            {
//                case true:
//                    Console.WriteLine("Outer switch block is executed");
//                    Console.WriteLine(a + " is a positive number");
//                    switch (a % 2 == 0)
//                    {
//                        case true:
//                            Console.WriteLine("Inner switch block is excecuted");
//                            Console.WriteLine(a + " is an even number");
//                            break;
//                        case false:
//                            Console.WriteLine("Inner switch block is excecuted");
//                            Console.WriteLine(a + " is an odd number");
//                            break;
//                    }
//                    break;

//                case false:
//                    Console.WriteLine("Outer switch block is excuted");
//                    Console.WriteLine(a + " is a negative number");
//                    switch (a % 2 == 0)
//                    {
//                        case true:
//                            Console.WriteLine("Inner switch block is excecuted");
//                            Console.WriteLine(a + " is an even number");
//                            break;
//                        case false:
//                            Console.WriteLine("Inner switch block is excecuted");
//                            Console.WriteLine(a + " is an odd number");
//                            break;
//                    }
//                    break;

//            }




//        }
//    }
//}
