using UnityEngine.SceneManagement;

namespace Patterns.Creational.Singleton
{
    public class ScenesManagerSingleton : Singleton<ScenesManagerSingleton>
    {
        public string GetCurrentScene()
        {
           return SceneManager.GetActiveScene().name;
        }
    }
}
