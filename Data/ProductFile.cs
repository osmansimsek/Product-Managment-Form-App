using FormApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp.Data
{
    internal class ProductFile
    {
        private const string FilePath = "product.txt";

        public List<Product> ListProduct()
        {
            List<Product> products = new List<Product>();

            if (File.Exists(FilePath))
            {
                string[] lines = File.ReadAllLines(FilePath);

                foreach (string line in lines)
                {
                    string[] data = line.Split(';');
                    if (data.Length == 5)
                    {
                        Product product = new Product
                        {
                            ProductName = data[0],
                            ProductCategory = data[1],
                            ProductPrice = Convert.ToDouble(data[2]),
                            ProductWeight = Convert.ToDouble(data[3]),
                            ProductColor = data[4]
                        };
                        products.Add(product);
                    }
                }
            }

            return products;
        }

        public void SaveProduct(Product product)
        {
            using (StreamWriter writer = new StreamWriter(FilePath, true))
            {
                string line = $"{product.ProductName};{product.ProductCategory};{product.ProductPrice};{product.ProductWeight};{product.ProductColor}";
                writer.WriteLine(line);
            }
        }

        public void UpdateProduct(List<Product> products)
        {
            File.Delete(FilePath);

            using (StreamWriter writer = new StreamWriter(FilePath, true))
            {
                foreach (Product product in products)
                {
                    string line = $"{product.ProductName} ; {product.ProductCategory} ; {product.ProductPrice} ; {product.ProductWeight} ; {product.ProductColor}";
                    writer.WriteLine(line);
                }
            }
        }

        public void DeleteProduct(List<Product> products, int index)
        {
            products.RemoveAt(index);
            UpdateProduct(products);
        }
    }
}
