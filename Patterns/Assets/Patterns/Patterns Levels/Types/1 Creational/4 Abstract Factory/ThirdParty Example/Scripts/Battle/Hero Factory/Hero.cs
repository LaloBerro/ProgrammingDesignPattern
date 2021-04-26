using UnityEngine;

namespace Patterns.Creational.AbstractFactory
{
	public abstract class Hero : MonoBehaviour
	{
		[SerializeField] protected string id;

		public string Id => id;
	}
}