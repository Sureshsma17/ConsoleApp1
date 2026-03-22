//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class _2ProductsPriceList
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the Product_1_price:");
//            double Product_1_price = double.Parse(Console.ReadLine());

//            double discount1 = Product_1_price * 2 / 100;
//            Console.WriteLine("2% discount on Product_1_price is:" + discount1);

//            double gst1 = Product_1_price * 10 / 100;
//            Console.WriteLine("10% gst on Product_1_price is:" + gst1);

//            double Product_1_finalprice = Product_1_price - discount1 + gst1;
//            Console.WriteLine("Final price of product1 is:" + Product_1_finalprice);

//            Console.WriteLine("Enter the Product_2_price:");
//            double Product_2_price = double.Parse(Console.ReadLine());

//            double discount2 = Product_2_price * 4 / 100;
//            Console.WriteLine("4% discount on Product_2_price is:" + discount2);

//            double gst2 = Product_2_price * 12 / 100;
//            Console.WriteLine("12% gst on Product_2_price is:" + gst2);

//            double Product_2_price_finalprice = Product_2_price - discount2 + gst2;
//            Console.WriteLine("Final price of product2 is:" + Product_2_price_finalprice);
//        }
//    }
//}
