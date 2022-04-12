using System;
using System.Globalization;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            Order order1 = new Order();
            order1.TotalAmount = 100;
            order1.ProductCount = 2;
            Order order2 = new Order();
            order2.TotalAmount = 165;
            order2.ProductCount = 3;
            DateTime dateTime =  DateTime.Now;
            shop.AddOrder(order1);
            shop.AddOrder(order2);
            Console.WriteLine("======================================= Add olunanlar ================================\n");
            foreach (var item in shop.Orders)
            {
                Console.WriteLine("Nomre:"+item.No + "       "+"Qiymet:"+item.TotalAmount/item.ProductCount +"        " + "Tarix:" + item.CreatedAt.ToString("F"));
            }

          
            Order order3 = new Order();
            order3.ProductCount = 1;
            order3.TotalAmount = 60;
            Order order4 = new Order();
            order4.TotalAmount = 10;
            order4.ProductCount = 2;
            shop.AddOrder(order3);
            shop.AddOrder(order4);
            Console.WriteLine("\n\n===================================== Yeni Add olunanlar ==============================\n");
            foreach (var item in shop.Orders)
            {
                Console.WriteLine("Nomre:" + item.No + "       " + "Qiymet:" + item.TotalAmount / item.ProductCount + "        " + "Tarix:" + item.CreatedAt.ToString("F"));
            }

            Console.WriteLine("\n\n========================== Axtarilan tarixde olanlarin  =====================\n");
            foreach (var item in shop.Orders)
            {
                if(item.CreatedAt>dateTime)
                    Console.WriteLine("Nomre:" + item.No + "       " + "Qiymet:" + item.TotalAmount / item.ProductCount + "        " + "Tarix:" + item.CreatedAt.ToString("F"));
            }

            Console.WriteLine("\n\n========================== Axtarilan tarixde olanlarin oratalmasi =====================\n");
            Console.WriteLine(shop.GetOrderAvg(dateTime));

            Console.WriteLine("\n\n=================================== Hamsinin oratalmasi ================================\n");
            Console.WriteLine(shop.GetOrderAvg());
            Console.WriteLine("\n\n=========================== Azxtarilan qiymet araliginda olanlar  ========================\n");
           foreach(var item in shop.FilterOrderByPrice(0, 50))
            {
                Console.WriteLine("Nomre:" + item.No + "       " + "Qiymet:" + item.TotalAmount / item.ProductCount + "        " + "Tarix:" + item.CreatedAt.ToString("F"));
            }
            Console.WriteLine("\n\n================================== Nomre sildikden  sonra  ================================\n");
            shop.RemoveOrderByNo(2);
            foreach (var item in shop.Orders)
            {
                Console.WriteLine("Nomre:" + item.No + "       " + "Qiymet:" + item.TotalAmount / item.ProductCount + "        " + "Tarix:" + item.CreatedAt.ToString("F"));
            }
        }
    }
}
