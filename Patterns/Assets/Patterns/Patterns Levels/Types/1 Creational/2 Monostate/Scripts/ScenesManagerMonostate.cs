using UnityEngine.SceneManagement;

namespace Patterns.Creational.Monostate
{
    public class ScenesManagerMonostate
    {
        private static string currentScene { get => SceneManager.GetActiveScene().name; }

        public string GetCurrentScene()
        {
            return ScenesManagerMonostate.currentScene;
        }
    }
}