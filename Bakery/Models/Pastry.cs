namespace Bakery.Models
{
	public class Pastry
	{
		
		public int PastryCost {get; private set;}
		
		public int PastryOrder {get; private set;}
		
		public Pastry(int userPastryOrder)
		{
		PastryOrder = userPastryOrder;
		PastryCost = ((((PastryOrder/4)*3)*2)+((PastryOrder%4)*2));
		}
		
	}
}

