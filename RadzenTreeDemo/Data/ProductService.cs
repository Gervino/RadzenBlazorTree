using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RadzenTreeDemo.Data
{
    public class ProductService
    {
        List<Category> categories = new List<Category>()
        {
            new Category() { CategoryID =1, CategoryName = "Category-1" },
            new Category() { CategoryID =2, CategoryName = "Category-2" },
            new Category() { CategoryID =3, CategoryName = "Category-3" }

        };

        List<Product> products = new List<Product>()
        {
            new Product() { ProductID =1, CategoryID =1, ProductName = "Computer", Price =500000},
            new Product() { ProductID =2, CategoryID =1, ProductName = "Mouse", Price =500000},
            new Product() { ProductID =3, CategoryID =2, ProductName = "Keyboard", Price =20000},
            new Product() { ProductID =4, CategoryID =2, ProductName = "Printer", Price =40000},
            new Product() { ProductID =5, CategoryID =3, ProductName = "Pendrive", Price =2000},
            new Product() { ProductID =6, CategoryID =3, ProductName = "Laptop", Price =100000},
            new Product() { ProductID =7, CategoryID =3, ProductName = "Speaker", Price =5000}
        };

        public async Task<List<Category>> CategoryList()
        {
            var categoryList = new List<Category>();
            foreach (var catg in categories)
            {
                catg.Products = products.Where(s => s.CategoryID == catg.CategoryID).ToList();
                categoryList.Add(catg);
            }

            return await Task.FromResult(categoryList);
        }
    }
}
