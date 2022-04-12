using System;

namespace ClassLibrary1
{
    public class Order
    {
        public Order()
        {
            _no++;
            No = _no;
            _createdAt=DateTime.Now;
            CreatedAt = _createdAt;


        }
        static int _no;
         public int No { get; }
 public int ProductCount { get; set; }
 public double TotalAmount { get; set; }
        static DateTime _createdAt;
       
 public DateTime CreatedAt { get; }
    }
}
