using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer;
namespace ApplicationLayer
{
    public class OrderRepo
    {
        private List<Order> orders = new List<Order>();

        public void AddNewOrder(Order order)
        {
            orders.Add(order);
        }
        public void RemoveOrder(Order order)
        {
            orders.Remove(order);
        }
    }
}
