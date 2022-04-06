using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Store
    {
        public Product[] Products=new Product[0];
        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }

        public void RemoveProductByNo(int no)
        {
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No == no)
                    continue;

                Console.WriteLine(Products[i].Name);
            }
        }

        public string[] FilterProductsByType(ProductType type)
        {
            string[] array = new string[0];
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Type==type)
                {
                    Array.Resize(ref array, array.Length + 1);
                    array[array.Length - 1] = Products[i].Name;
                }
            }
            return array;
        }
        public string[] FilterProductByName(string name)
        {
            string[] array = new string[0];
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Name == name)
                {
                    Array.Resize(ref array, array.Length + 1);
                    array[array.Length - 1] = Products[i].Name;
                }
            }
            return array;
        }
    }
}
