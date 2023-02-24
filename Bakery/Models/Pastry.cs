using System;
using System.Collections.Generic;

namespace Bakery.Models
{
	public class Pastry
	{
		private int _pastryOrder;

		public int PastryOrder
		{
			get { return _pastryOrder; }
		}
		public Pastry(int userOrder)
		{
		int	_pastryOrder = userOrder;
		}
			
	}
}

