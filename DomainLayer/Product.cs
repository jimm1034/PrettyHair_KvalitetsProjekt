using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
	public class Product
	{
		private string productId;
		private string name;


		public string ProductId { get { return this.name; } set { this.name = value; } }
		public string Name { get { return this.name; } set { this.name = value; } }


		public Product(string productId, string name)
		{
			ProductId = productId;
			Name = name;
		}

	}
}
