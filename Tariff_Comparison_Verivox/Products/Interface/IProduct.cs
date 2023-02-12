namespace Tariff_Comparison_Verivox.Products.Interface
{
	public interface IProduct
	{
		string GetProductName();
		double CalculateAnnualCost(int consumption);
	}
}
