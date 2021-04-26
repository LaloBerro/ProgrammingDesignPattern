using UnityEngine;

namespace Patterns.Creational.Prototype
{
	public class PrototypeCube : Prototype
	{
        [Header("Config")]
        [SerializeField] private GameObject mesh;
        [SerializeField] private Renderer rend;

        private MaterialPropertyBlock _propertyBlock;

        private void Awake()
        {
            _propertyBlock = new MaterialPropertyBlock();
        }

        public override GameObject Clone(Vector3 position)
        {
            GameObject clone = Instantiate(mesh);
            rend.GetPropertyBlock(_propertyBlock);

            //Copy and apply all the rotation, scale, and material properties
            clone.transform.position = position;
            clone.transform.rotation = transform.rotation;
            clone.transform.localScale = transform.localScale;
            clone.GetComponent<Renderer>().SetPropertyBlock(_propertyBlock);

            return clone;
        }
    }
}