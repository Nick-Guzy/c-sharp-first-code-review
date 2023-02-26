using System;
using System.Collections.Generic;

namespace Bakery.Models
{
	public class Pastry
	{
		private int _pastryOrder;
		private int _pastryCost;
		
		public int PastryCost 
		{
			get { return _pastryCost; }
		}
		public int PastryOrder
		{
			get { return _pastryOrder; }
		}
		public Pastry(int userPastryOrder)
		{
		_pastryOrder = userPastryOrder;
		_pastryCost = ((((_pastryOrder/4)*3)*2)+((_pastryOrder%4)*2));
		}			
	}
}

