using UnityEngine;

namespace Patterns.Creational.FactoryMethod
{
	public class PowerUp : MonoBehaviour
	{
		[SerializeField] protected string id;

		public string Id => id;
	}
}
