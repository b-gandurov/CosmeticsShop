using CosmeticsShop.Core;
using CosmeticsShop.Models;
using System;
using System.Collections.Generic;
using CosmeticsShop.Helpers;

namespace CosmeticsShop.Commands
{
    public class AddProductToCategory : ICommand
    {
        private const int MinNameLength = 3;
        private const int MaxNameLength = 10;
        private readonly CosmeticsRepository cosmeticsRepository;

        public AddProductToCategory(CosmeticsRepository productRepository)
        {
            this.cosmeticsRepository = productRepository;
        }

        public string Execute(List<string> parameters)
        {
            // TODO: Validate parameters count
            string categoryName = parameters[0];
            string productName = parameters[1];

            StringValidators.StringLengthValidator(MinNameLength,MaxNameLength,productName,
                $"Name must be between {MinNameLength} and {MaxNameLength}");

            Category category = this.cosmeticsRepository.FindCategoryByName(categoryName);
            Product product = this.cosmeticsRepository.FindProductByName(productName);

            category.AddProduct(product);

            return $"Product {productName} added to category {categoryName}!";
        }
    }
}
