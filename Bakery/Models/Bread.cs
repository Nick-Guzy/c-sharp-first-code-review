
namespace Bakery.Models 
{
	public class Bread
{
		private int _breadOrder;
		private int _breadCost;
		
		public int BreadCost 
		{
			get { return _breadCost; }
		}
		public int BreadOrder
		{
			get { return _breadOrder; }
		}
		public Bread(int userBreadOrder)
		{
		_breadOrder = userBreadOrder;
		_breadCost = ((((_breadOrder/3)*2)*5)+((_breadOrder%3)*5));
		}
			
	}
}