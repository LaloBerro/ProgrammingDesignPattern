using UnityEngine;

namespace Patterns.Creational.AbstractFactory
{
	public class HeroFactory : MonoBehaviour
	{
		private readonly HeroesConfiguration heroesConfiguration;

		public HeroFactory(HeroesConfiguration heroesConfiguration)
        {
			this.heroesConfiguration = heroesConfiguration;
        }

		public Hero Create(string id)
        {
			var hero = heroesConfiguration.GetHeroPrefabById(id);

			return Object.Instantiate(hero);
        }
	}
}