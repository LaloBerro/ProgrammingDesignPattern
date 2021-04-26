using System;
using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Creational.FactoryMethod
{
    [CreateAssetMenu(menuName = "Factory Method/PowerUps/up configuration")]
    public class PowerUpsConfiguration : ScriptableObject
    {
        [SerializeField] private PowerUp[] powerUps;
        private Dictionary<string, PowerUp> idToPowerUp;

        private void Awake()
        {
            idToPowerUp = new Dictionary<string, PowerUp>(powerUps.Length);
            foreach (var powerUp in powerUps)
            {
                if (idToPowerUp.ContainsKey(powerUp.Id)) continue;
                idToPowerUp.Add(powerUp.Id, powerUp);
            }
        }

        public PowerUp GetPowerUpPrefabById(string id)
        {
            if (!idToPowerUp.TryGetValue(id, out var powerUp))
            {
                throw new Exception($"PowerUp with id {id} does not exit");
            }
            return powerUp;
        }
    }
}
