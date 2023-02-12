using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tariff_Comparison_Verivox.Products;
using Tariff_Comparison_Verivox.Tariff;

namespace Tariff_Comparison_Tests.Tariff
{
	[TestClass]
	public class ProductTariffTest
	{
		[TestMethod]
		public void AllTariffSortedByAnnualCost_Success()
		{
			//Arrange
			int consumption = 3500;

			//Act
			List<ProductTariff> productTariffs = new List<ProductTariff>();

			productTariffs.Add(new ProductTariff(new BasicTariffProduct(), consumption));
			productTariffs.Add(new ProductTariff(new PackagedTariffProduct(), consumption));

			productTariffs.Sort(delegate (ProductTariff x, ProductTariff y)
			{
				return x.GetAnnualCharge().CompareTo(y.GetAnnualCharge());
			});

			//Assert
			Assert.AreEqual(expected: 800, actual: productTariffs[0].GetAnnualCharge());
		}
	}
}
