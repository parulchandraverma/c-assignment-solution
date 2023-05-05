using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace ConsoleApp1
{
    internal class Assignment_4
    {
        public static void Main()
        {
            abc obj = new abc();
            obj.customerInput();
            obj.productdetails();
            obj.amount();



        }
    }






    internal class abc
    {
        int pcode;
        string pname;
        double qty_in_stock;
        double price;
        const string brand = "Samsung";
        const double fixeddiscount = 0.05;





        public void customerInput()
        {
            Console.WriteLine("Enter the product code");
            pcode = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter the product name");
            pname = Console.ReadLine();
            Console.WriteLine("Enter the price");
            price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the quantity");
            qty_in_stock = Byte.Parse(Console.ReadLine());





        }
        public void productdetails()
        {
            Console.WriteLine("Product code is {0} ", pcode);
            Console.WriteLine("Product name is {0} ", pname);
            Console.WriteLine("Price of the Product {0} ", price);
            //Console.WriteLine("Product quantity in stock is {0} ", qty_in_stock );
            Console.WriteLine("Product Brand name is {0}", brand);






        }
        public void amount()
        {
            double discount;
            double amount;
            amount = qty_in_stock * price;
            discount = amount * (0.50 + fixeddiscount);
            amount = amount - discount;
            Console.WriteLine("Amount is :- {0} ", amount);





        }
    }
}