using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tariff_Comparison_Verivox.Products;
using Tariff_Comparison_Verivox.Tariff;

namespace Tariff_Comparison_Verivox
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter your annual consumption (kWh/year): ");
			
			var input = Console.ReadLine();
			int consumption;

			while (!int.TryParse(input, out consumption))
			{
				Console.WriteLine("This is not a valid input, please provide consumtion in numbers !");
				input = Console.ReadLine();
			}

			List<ProductTariff> productTariffs = new List<ProductTariff>();

			productTariffs.Add(new ProductTariff(new BasicTariffProduct(), consumption));
			productTariffs.Add(new ProductTariff(new PackagedTariffProduct(), consumption));

			productTariffs.Sort(delegate (ProductTariff x, ProductTariff y)
			{
				return x.GetAnnualCharge().CompareTo(y.GetAnnualCharge());
			});

			Console.OutputEncoding = Encoding.Unicode;
			Console.WriteLine(String.Join(Environment.NewLine, productTariffs));


			Console.ReadLine();

		}
	}
}
