﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
	public class Order
	{
		private DateTime orderDate;
		private DateTime deliveryDate;
		private double totalPrice;

		public DateTime OrderDate { get { return this.orderDate; } set { this.orderDate = value; } }
		public DateTime DeliveryDate { get { return this.deliveryDate; } set { this.deliveryDate = value; } }
		public double TotalPrice { get { return this.totalPrice; } set { this.totalPrice = value; } }

		public Order(DateTime orderDate, DateTime deliverDate, double totalprice)
		{
			OrderDate = orderDate;
			DeliveryDate = deliverDate;
			TotalPrice = totalPrice;
		}

	}
}