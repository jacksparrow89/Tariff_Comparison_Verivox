using Tariff_Comparison_Verivox.Constants;
using Tariff_Comparison_Verivox.Products.Interface;

namespace Tariff_Comparison_Verivox.Products
{
	public class PackagedTariffProduct : IProduct
	{
		public double CalculateAnnualCost(int consumption)
		{
			var extraCost = 0.0;

			var additionalConsumption = consumption - 4000;

			if (additionalConsumption > 0)
				extraCost = additionalConsumption * 0.3;

			return 800 + extraCost;
		}

		public string GetProductName()
		{
			return ProductNames.PackagedTariff;
		}
	}
}
