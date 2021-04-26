using System.Collections.Generic;
using UnityEngine;
using System;

namespace Patterns.Creational.FactoryMethod
{
	public abstract class ProductsConfiguration<K> : ScriptableObject
	{
        [SerializeField] private UnityEngine.Object[] products;
        private Dictionary<K, IProduct<K>> idToPowerUp;

        private void Awake()
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            idToPowerUp = new Dictionary<K, IProduct<K>>(products.Length);
            foreach (var productObj in products)
            {
                IProduct<K> product;
                try
                {
                    product = productObj as IProduct<K>;

                    if (idToPowerUp.ContainsKey(product.Id)) continue;

                    idToPowerUp.Add(product.Id, product);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public IProduct<K> GetProductById(K id)
        {
            if (!idToPowerUp.TryGetValue(id, out var product))
            {
                throw new Exception($"Product with id {id} does not exit");
            }
            return product;
        }
    }
}