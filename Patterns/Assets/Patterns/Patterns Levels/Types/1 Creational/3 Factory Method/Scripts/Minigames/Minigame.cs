using UnityEngine;

namespace Patterns.Creational.FactoryMethod
{
    [CreateAssetMenu(menuName = "Factory Method/Minigames/Minigame")]
    public class Minigame : ScriptableObject, IProduct<string>
    {
        [SerializeField] private string id;

        public string Id => id;
    }
}