//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class GST_calculations
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the Product Price:");
//            double price = double.Parse(Console.ReadLine());

//            double discount = price * 2 / 100;
//            Console.WriteLine("2% discount on product price is:" + discount);

//            double central_gst = price * 5 / 100;
//            Console.WriteLine("5% central_gst on product price is:" + central_gst);

//            double state_gst = price * 5 / 100;
//            Console.WriteLine("5% state_gst on product price is:" + state_gst);


//            double finalprice = price - discount + central_gst+state_gst;
//            Console.WriteLine("Final price of product is:" + finalprice);


//        }

//    }
//}
