using UnityEngine;

namespace Patterns.Creational.FactoryMethod
{
	public class MinigamesFactory : Factory<string>
	{
		public MinigamesFactory(ProductsConfiguration<string> productsConfiguration) : base(productsConfiguration) { }
	}
}