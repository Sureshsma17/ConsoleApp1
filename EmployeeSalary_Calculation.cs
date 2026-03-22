//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class EmployeeSalary_Calculation
//    {
//        static void Main(string[] args)
//        {
//            //double esal = 100000;
//            Console.WriteLine("Enter Employee Salary:");
//            double esal = double.Parse(Console.ReadLine());
//            //Console.WriteLine("Enter Employee Salary:"+esal);

//            double ptax = esal * 5 / 100;
//            Console.WriteLine("5% Professional tax is:" + ptax);

//            double hloan = esal * 10 / 100;
//            Console.WriteLine("10% Home Loan is:" + hloan);

//            double netsal = esal - ptax - hloan;
//            Console.WriteLine("Net Salary is:" + netsal);
//        }
//    }
//}
