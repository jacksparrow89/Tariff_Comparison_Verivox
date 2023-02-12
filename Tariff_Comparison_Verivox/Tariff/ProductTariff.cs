using Tariff_Comparison_Verivox.Products.Interface;

namespace Tariff_Comparison_Verivox.Tariff
{
	public class ProductTariff
	{
		private readonly string ProductName;
		private readonly double AnnualCost;

		public ProductTariff(IProduct product, int consumption)
		{
			ProductName = product.GetProductName();
			AnnualCost = product.CalculateAnnualCost(consumption);
		}

		public double GetAnnualCharge()
		{
			return AnnualCost;
		}

		public override string ToString()
		{
			return
				"Product Name='" + ProductName + "  " +
				",Annual Cost(€/year)= €" + AnnualCost;
		}

	}
}
