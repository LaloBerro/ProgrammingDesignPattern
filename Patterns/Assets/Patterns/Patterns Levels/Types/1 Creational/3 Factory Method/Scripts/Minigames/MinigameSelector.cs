using UnityEngine;

namespace Patterns.Creational.FactoryMethod
{
	public class MinigameSelector : MonoBehaviour
	{
        [SerializeField] private MinigamesConfiguration _minigamesConfiguration;

        private Factory<string> _minigameFactory;

        private void Awake()
        {
            _minigameFactory = new MinigamesFactory(Instantiate(_minigamesConfiguration));
        }

        public void LoadMinigame(string id)
        {
            Minigame minigame = (Minigame)_minigameFactory.Create(id);

            Debug.Log("Load minigame: " + minigame.Id);
        }
    }
}