using UnityEngine;

namespace Patterns.Creational.FactoryMethod
{
	public class PowerUpsFactory
	{
		private readonly PowerUpsConfiguration powerUpsConfiguration;

		public PowerUpsFactory (PowerUpsConfiguration powerUpsConfiguration)
        {
			this.powerUpsConfiguration = powerUpsConfiguration;
        }

		public PowerUp Create(string id)
        {
			var prefab = powerUpsConfiguration.GetPowerUpPrefabById(id);

			return Object.Instantiate(prefab);
        }
	}
}
