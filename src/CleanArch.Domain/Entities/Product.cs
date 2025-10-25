using System;

namespace CleanArch.Domain.Entities
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public decimal Price { get; private set; }

        public Product(string name, decimal price)
        {
            Update(name, price);
        }

        public void Update(string name, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Product name is required.");

            if (price <= 0)
                throw new ArgumentException("Price must be greater than zero.");

            Name = name;
            Price = price;
        }
    }
}
