using DomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
    public class CustomerRepo
    {
        private List<Customer> customers = new List<Customer>();


        public void AddNewCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public void RemoveCustomer(Customer customer)
        {
            customers.Remove(customer);
        }
    }
}
