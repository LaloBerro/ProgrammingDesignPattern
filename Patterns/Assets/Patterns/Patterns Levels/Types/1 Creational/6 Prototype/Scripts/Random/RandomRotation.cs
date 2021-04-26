using System.Collections;
using UnityEngine;

namespace Patterns.Creational.Prototype
{
	public class RandomRotation : MonoBehaviour
	{
        [Header("Config")]
        [SerializeField] private float speed;

        private void Start()
        {
            StartCoroutine(ChangeColor());
        }

        private IEnumerator ChangeColor()
        {
            Quaternion randomRotation;
            float t;

            while (true)
            {
                randomRotation = Random.rotation;
                t = 0;

                while (t < 1)
                {
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, randomRotation, t);
                    t += Time.deltaTime * speed;
                    yield return null;
                }               
            }
        }

    }
}