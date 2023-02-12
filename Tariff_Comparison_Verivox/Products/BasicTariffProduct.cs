using Tariff_Comparison_Verivox.Constants;
using Tariff_Comparison_Verivox.Products.Interface;

namespace Tariff_Comparison_Verivox.Products
{
	public class BasicTariffProduct : IProduct
	{
		public double CalculateAnnualCost(int consumption)
		{
			consumption = consumption > 0 ? consumption : 0;

			var baseCost = 60;
			var addedConsumptionCost = consumption * 0.22;

			return baseCost + addedConsumptionCost;
		}

		public string GetProductName()
		{
			return ProductNames.BasicTariff;
		}
	}
}
