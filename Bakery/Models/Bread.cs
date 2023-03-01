namespace Bakery.Models 
{
	public class Bread
{
	public int BreadCost {get; private set;}
		
	public int BreadOrder {get; private set;}
	public Bread(int userBreadOrder)
	{
		BreadOrder = userBreadOrder;
		BreadCost = ((((BreadOrder/3)*2)*5)+((BreadOrder%3)*5));
	}
			
	}
}