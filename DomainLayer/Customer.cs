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
        private int zip;

		public int CustomerId
        { get { return this.customerId; } set { this.customerId = value; } }
		public string FirstName
        { get { return this.firstName; } set { this.firstName = value; } }
		public string LastName
        { get { return this.lastName; } set { this.lastName = value; } }
		public string FullName
        { get { return FirstName + " " + LastName; } }
		public string Address
        { get { return this.address; } set { this.address = value; } }
        public int ZipCode
        { get { return this.zip; } set { this.zip = value; } }


        public Customer(int customerId, string fName, string lName, 
            string address, int zip)
		{
			CustomerId = customerId;
			FirstName = fName;
			LastName = lName;
			Address = address;
            ZipCode = zip;
		}

		public Customer(int customerId, string fName, string lName, int zip) : 
            this(customerId, fName, lName, "NOT GIVEN", zip)
		{

		}
	}
}

