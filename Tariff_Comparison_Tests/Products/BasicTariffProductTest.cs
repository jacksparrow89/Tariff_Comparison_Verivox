using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tariff_Comparison_Verivox.Constants;
using Tariff_Comparison_Verivox.Products;

namespace Tariff_Comparison_Tests.Products
{
	[TestClass]
	public class BasicTariffProductTest
	{
		[TestMethod]
		public void GetTheProductName_Success()
		{
			//Act
			var basicProduct = new BasicTariffProduct();
			var productName = basicProduct.GetProductName();

			//Assert
			Assert.AreEqual(expected: ProductNames.BasicTariff, actual: productName);
		}

		[TestMethod]
		public void CalculateAnnualCost_Success()
		{
			//Arrange
			int consumption = 3500;

			//Act
			var basicProduct = new BasicTariffProduct();
			var annualCost = basicProduct.CalculateAnnualCost(consumption);

			//Assert
			Assert.AreEqual(expected: 830, actual: annualCost);
		}


	}
}
