using HelperStockBeta.Domain.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HelperStockBeta.Domain.Entities
{
    [Table("Produto")]
    public sealed class Product : Entity
    {
       
        public string Name { get; private set; }

        public string Description { get; private set; }

        public decimal Price { get; private set; }

        public int Stock { get; private set;}

        public string Image { get; private set; }

        
        public Product(string name, string description, decimal price, int stock, string image)
        {
            ValidationDomain(name, description, price, stock, image);

        }

        public Product(int Id, string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(Id > 0,"Invalid negative values for id.");
            ValidationDomain(name, description, price, stock, image);

        }

        private void ValidationDomain(string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid Name, name is required.");
            DomainExceptionValidation.When(name.Length < 3, "Invalid short names, minimum 3 characteres.");
            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Invalid descreption, descreption is required.");
            DomainExceptionValidation.When(description.Length < 5, "Invalid short description. minimum 3 characteres.");
            DomainExceptionValidation.When(price < 0, "Invalid negative values for price.");
            DomainExceptionValidation.When(stock < 0, "Invalid negative values for stock.");

            DomainExceptionValidation.When(Image.Length > 250,
                "Invalid Lon URL, maximum 250 characteres.");

            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
        }

        public void Update(int Id, string name, string description, decimal price, int stock, string image, int categoryId)
        {
            ValidationDomain(name, description, price, stock, image);
            categoryId = categoryId;
        }

        //Relacionamento com categoria

        public int categoryId { get; set; }

        public Category Category { get; set; }

    }
}
