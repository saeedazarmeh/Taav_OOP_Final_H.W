using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test9
{
    internal class Order
    {
        internal static List<Order> Orders = new List<Order>();
        protected decimal _totalPrice=0;

        public Order( List<FastFood> fastFoods)
        {
            BillDateTime = DateTime.Now;
            FastFoods = fastFoods;
        }

        public int Id { get;private set; }
        public DateTime BillDateTime{ get;private set; }
        public bool isServed{ get;private set; }=false;
        public List<FastFood> FastFoods { get;private set; }
        public decimal TotalPrice{ 
            get 
            {
                return _totalPrice;
            }
            set
            {
                foreach (FastFood fastFood in FastFoods)
                {
                    _totalPrice = _totalPrice + fastFood.Number * fastFood.UnitPrice;
                }
                TotalPrice = _totalPrice;
            }
        }
        internal void SetId()
        {
            if (Orders.Count > 0)
                Id = Orders.Last().Id + 1;

            else Id = 1;
        }
        internal void SetServed()
        {
            isServed = true;
        }

        internal static void FinalizeOrder()
        {
            var order=new Order(FastFood.foods);
            FastFood.foods.Clear();
            order.SetId();
            Orders.Add(order);
        }
        internal static void ShowOrders()
        {
            var dayOrders = Orders.Where(o => o.isServed == false);
            foreach(var order in dayOrders)
            {
                Console.WriteLine($"Order Num:{order.Id} TotalPrice:{order.TotalPrice} ");
                foreach(var food in order.FastFoods)
                {
                    food.ShowDetails();
                }
            }
        }
}
}
