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
		private string firstName;
		private string lastName;
		private string address;

		public int CustomerId { get { return this.customerId; } set { this.customerId = value; } }
		public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
		public string LastName { get { return this.lastName; } set { this.lastName = value; } }
		public string FullName { get { return FirstName + " " + LastName; } }
		public string Address { get { return this.address; } set { this.address = value; } }


		public Customer(int customerId, string fname, string lname, string address)
		{
			CustomerId = customerId;
			FirstName = fname;
			LastName = lname;
			Address = address;
		}

		public Customer(int customerId, string fname, string lname) : this(customerId, fname, lname, "NOT GIVEN")
		{

		}

		public Type Method(Type t)
		{
			throw new NotImplementedException();
		}
	}
}

