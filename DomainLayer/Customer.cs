using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
	public class Customer
	{
		private int customerId;
		private string name;
		private string address;

		public int CustomerId { get { return this.customerId; } set { this.customerId = value; } }
		public string Name { get { return this.name; } set { this.name = value; } }
		public string Address { get { return this.address; } set { this.address = value; } }


		public Customer(int customerId, string name, string address)
		{
			CustomerId = customerId;
			Name = name;
			Address = address;
		}

		public Type Method(Type t)
		{
			throw new NotImplementedException();
		}
	}
}

