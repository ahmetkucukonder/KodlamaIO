using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Category> categories = new List<Category>
            {
                new Category{CategoryID=1,CategoryName="Computers"},
                new Category{CategoryID=2,CategoryName="Phones"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductID=0,CategoryID=1,ProductName="Acer Laptop",QuantityPerUnit="64GB RAM",UnitPrice=6400,UnitsInStock=6},
                new Product{ProductID=1,CategoryID=1,ProductName="Asus Laptop",QuantityPerUnit="32GB RAM",UnitPrice=6400,UnitsInStock=2},
                new Product{ProductID=2,CategoryID=2,ProductName="Xiaomi Phone",QuantityPerUnit="256GB Storage",UnitPrice=5500,UnitsInStock=2},
                new Product{ProductID=3,CategoryID=2,ProductName="Samsung Phone",QuantityPerUnit="128GB Storage",UnitPrice=4600,UnitsInStock=5},
                new Product{ProductID=4,CategoryID=1,ProductName="Lenovo Laptop",QuantityPerUnit="32GB RAM",UnitPrice=4400,UnitsInStock=5},
                new Product{ProductID=5,CategoryID=2,ProductName="Apple Phone",QuantityPerUnit="16GB Storage",UnitPrice=9999,UnitsInStock=14},
            };
            //AnyTest(products);
            //FindTest(products);
            //FindAllTest(products);
            //AscDescTest(products);
            //ClassicLinqTest(products);
            //InnerJoinTest(categories, products);
        }

        private static void InnerJoinTest(List<Category> categories, List<Product> products)
        {
            var result = from p in products
                         join c in categories
                         on p.CategoryID equals c.CategoryID
                         where p.UnitPrice > 5000
                         orderby p.UnitPrice descending
                         select new ProductDto { ProductID = p.ProductID, CategoryName = c.CategoryName, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var productDto in result)
            {
                Console.WriteLine("{0} --- {1}", productDto.ProductName, productDto.CategoryName);
            }
        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 4600
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select new ProductDto { ProductID = p.ProductID, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void AscDescTest(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenByDescending(p => p.ProductName);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(result);
        }

        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductID == 15);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Dell Laptop");
            Console.WriteLine(result);
        }
    }

    class ProductDto
    {
        //DTO = Data Transformation Operation

        public int ProductID { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }

    class Product
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
