using System.Collections;
using UnityEngine;

namespace Patterns.Creational.Prototype
{
	public class RandomColor : MonoBehaviour
	{
		[Header("Config")]
		[SerializeField] private bool changeAlongTime;
		[SerializeField] private float speed;
        [SerializeField] private Renderer _renderer;

        private MaterialPropertyBlock _propertyBlock;

        private void Awake()
        {
            _propertyBlock = new MaterialPropertyBlock();

            _propertyBlock.SetColor("_Color", Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f));

            _renderer.SetPropertyBlock(_propertyBlock);
        }

        private void Start()
        {
            if (changeAlongTime)
                StartCoroutine(ChangeColor());
        }

        private IEnumerator ChangeColor()
        {
            Color randomColor;
            float t;
            while (true)
            {
                randomColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f); ;
                t = 0;

                while (t < 1)
                {
                    _propertyBlock.SetColor("_Color", Color.Lerp(_propertyBlock.GetColor("_Color"), randomColor, t));
                    _renderer.SetPropertyBlock(_propertyBlock);
                    t += Time.deltaTime * speed;

                    yield return null;
                }
            }
        }
    }
}