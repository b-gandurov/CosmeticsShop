using System.Collections.Generic;
using System.Text;
using CosmeticsShop.Helpers;

namespace CosmeticsShop.Models
{
    
    public class Category
    {
        private int MinNameValue = 3;
        private int MaxNameValue = 10;
        private string NameErrorMessage = "Name should be between {0} and {1} symbols";
        private int MinBrandValue = 2;
        private int MaxBrandValue = 10;
        private string name;
        private readonly List<Product> products;

        public Category(string name)
        {
            this.Name = name;
            this.products = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                //TODO - validate value - bozhil
                StringValidators.StringLengthValidator(MinNameValue,MaxBrandValue,value,string.Format(NameErrorMessage,MinNameValue,MaxNameValue));
                this.name = value;
            }
        }

        public List<Product> Products
        {
            get
            {
                // return a copy
                return new List<Product>(this.products);
            }
        }

        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            this.products.Remove(product);
        }

        public string Print()
        {
            var strBuilder = new StringBuilder();
            strBuilder.AppendLine($"#Category: {this.name}");

            if (this.products.Count == 0)
            {
                strBuilder.AppendLine(" #No products in this category");
                return strBuilder.ToString().Trim();
            }

            foreach (Product product in this.products)
            {
                strBuilder.AppendLine(product.Print());
                strBuilder.AppendLine(" ===");
            }

            return strBuilder.ToString().Trim();
        }
    }
}
