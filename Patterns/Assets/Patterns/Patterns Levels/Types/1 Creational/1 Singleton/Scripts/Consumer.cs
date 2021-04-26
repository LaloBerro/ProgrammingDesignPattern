using UnityEngine;

namespace Patterns.Creational.Singleton
{
    public class Consumer : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log("The Current Scene is " + ScenesManagerSingleton.Instance.GetCurrentScene());
        }
    }
}