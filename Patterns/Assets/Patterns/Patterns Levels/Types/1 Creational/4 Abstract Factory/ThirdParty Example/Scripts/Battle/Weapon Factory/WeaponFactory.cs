using UnityEngine;

namespace Patterns.Creational.AbstractFactory
{
	public class WeaponFactory : MonoBehaviour
	{
		private readonly WeaponsConfiguration weaponConfiguration;

		public WeaponFactory(WeaponsConfiguration weaponConfiguration)
		{
			this.weaponConfiguration = weaponConfiguration;
		}

		public Weapon Create(string id)
		{
			var hero = weaponConfiguration.GetWeaponPrefabById(id);

			return Object.Instantiate(hero);
		}
	}
}