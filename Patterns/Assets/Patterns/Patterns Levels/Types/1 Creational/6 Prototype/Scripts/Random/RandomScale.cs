using System.Collections;
using UnityEngine;

namespace Patterns.Creational.Prototype
{
	public class RandomScale : MonoBehaviour
	{
        [Header("Config")]
        [SerializeField] private float speed;

        private void Start()
        {
            StartCoroutine(ChangeColor());
        }

        private IEnumerator ChangeColor()
        {
            Vector3 randomScale;
            float t;

            while (true)
            {
                float randomNumber = Random.Range(0.3f, 1);
                randomScale = new Vector3(randomNumber, randomNumber, randomNumber);
                t = 0;

                while (t < 1)
                {
                    transform.localScale = Vector3.Lerp(transform.localScale, randomScale, t);
                    t += Time.deltaTime * speed;
                    yield return null;
                }
            }
        }
    }
}