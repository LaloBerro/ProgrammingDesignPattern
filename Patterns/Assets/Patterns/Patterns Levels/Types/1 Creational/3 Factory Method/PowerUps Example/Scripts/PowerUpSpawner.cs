using UnityEngine;

namespace Patterns.Creational.FactoryMethod
{
	public class PowerUpSpawner : MonoBehaviour
	{
		[SerializeField] private PowerUpsConfiguration _powerUpsConfiguration;

		private PowerUpsFactory _powerUpsFactory;

        private void Awake()
        {
            _powerUpsFactory = new PowerUpsFactory(Instantiate(_powerUpsConfiguration));
        }

        private void Start()
        {
            SpawnPowerUps("Strong");
        }

        private void SpawnPowerUps(string id)
        {
			_powerUpsFactory.Create(id);
        }
	}
}