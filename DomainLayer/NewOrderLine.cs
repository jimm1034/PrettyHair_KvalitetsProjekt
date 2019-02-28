using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
	public class NewOrderLine
	{
		private int quantity;
		private double price;

		public int Quantity { get { return this.quantity; } set { this.quantity = value; } }
		public double Price { get { return this.price; } set { this.price = value; } }

		public NewOrderLine(int quantity, double price)
		{
			Quantity = quantity;
			Price = price;
		}

	}
}
