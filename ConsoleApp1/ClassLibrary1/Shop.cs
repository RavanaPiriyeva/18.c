using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public  class Shop
 
    {

        public List<Order> Orders = new List<Order>();
        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
        public double GetOrderAvg()
        {
          
            double sum = 0;
            foreach (var item in Orders)
            {
                sum += item.TotalAmount/item.ProductCount;
            }
            return sum / Orders.Count;
        }
        public double GetOrderAvg(DateTime dateTime)
        {
            double sum = 0;
            foreach (var item in Orders)
            {
                if (item.CreatedAt >= dateTime) 
                { 
                sum += item.TotalAmount / item.ProductCount; 
                }
            }
            
            return sum/(Orders.FindAll(x=>x.CreatedAt>=dateTime).Count);
        }
        public void RemoveOrderByNo(int no)
        {
            Orders.Remove(Orders.Find(x => x.No == no));

        }
        public List<Order> FilterOrderByPrice(int min ,int max)
        {
           return Orders.FindAll(x=>x.TotalAmount/x.ProductCount >= min && x.TotalAmount / x.ProductCount <= max);
        }
    }
}
