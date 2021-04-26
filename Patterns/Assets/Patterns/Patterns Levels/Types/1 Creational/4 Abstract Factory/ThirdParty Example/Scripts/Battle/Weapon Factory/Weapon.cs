using UnityEngine;

namespace Patterns.Creational.AbstractFactory
{
	public class Weapon : MonoBehaviour
	{
		[SerializeField] protected string id;

		public string Id => id;
	}
}