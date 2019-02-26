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
		private float price;

		public int Quantity { get { return this.quantity; } set { this.quantity = value; } }
		public float Price { get { return this.price; } set { this.price = value; } }

		public NewOrderLine(int quantity, float price)
		{
			Quantity = quantity;
			Price = price;
		}

	}
}
