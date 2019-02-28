using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
	public class Customer
	{
		private string firstName;
		private string lastName;
		private string address;
        private int zip;

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


        public Customer(string fName, string lName, 
            string address, int zip)
		{
			FirstName = fName;
			LastName = lName;
			Address = address;
            ZipCode = zip;
		}

		public Customer(string fName, string lName, int zip) : 
            this(fName, lName, "NOT GIVEN", zip)
		{

		}
	}
}

