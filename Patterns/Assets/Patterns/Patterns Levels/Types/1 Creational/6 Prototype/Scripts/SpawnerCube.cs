using UnityEngine;

namespace Patterns.Creational.Prototype
{
	public class SpawnerCube : MonoBehaviour
	{
		[Header("Config")]
		[SerializeField] private Prototype prototype;
		[SerializeField] private Transform spawnPoint;
		[SerializeField] private int amount;

		public void Spawn()
        {
            for (int i = 0; i < amount; i++)
            {
				prototype.Clone(spawnPoint.position).AddComponent<Rigidbody>();
            }
        }
	}
}