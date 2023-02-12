using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tariff_Comparison_Verivox.Constants;
using Tariff_Comparison_Verivox.Products;

namespace Tariff_Comparison_Tests.Tariff
{
	[TestClass]
	public class PackagedTariffProductTest
	{
		[TestMethod]
		public void GetTheProductName_Success()
		{
			//Act
			var basicProduct = new PackagedTariffProduct();
			var productName = basicProduct.GetProductName();

			//Assert
			Assert.AreEqual(expected: ProductNames.PackagedTariff, actual: productName);
		}

		[TestMethod]
		public void CalculateAnnualCost_Success()
		{
			//Arrange
			int consumption = 3500;

			//Act
			var basicProduct = new PackagedTariffProduct();
			var annualCost = basicProduct.CalculateAnnualCost(consumption);

			//Assert
			Assert.AreEqual(expected: 800, actual: annualCost);
		}
	}
}
