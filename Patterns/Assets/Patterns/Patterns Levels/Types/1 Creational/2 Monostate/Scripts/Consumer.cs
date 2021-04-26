using UnityEngine;

namespace Patterns.Creational.Monostate
{
	public class Consumer : MonoBehaviour
	{
        private void Start()
        {
            Debug.Log("The Current Scene is " + new ScenesManagerMonostate().GetCurrentScene());
        }
    }
}
