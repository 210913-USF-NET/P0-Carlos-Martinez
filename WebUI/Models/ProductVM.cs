using System.ComponentModel.DataAnnotations;
using Models;

namespace WebUI.Models
{
    public class ProductVM
    {
        public ProductVM() { }

        // constructor w/ Name
        public ProductVM(string name)
        {
            this.Name = name;
        }

        public ProductVM(string name, int Price, string Description) : this(name)
        {
            this.Price = Price;
            this.Description = Description;
        }

        public ProductVM(Product prod)
        {
            this.Id = prod.Id;
            this.Name = prod.Name;
            this.Price = prod.Price;
            this.Description = prod.Description;
        }

        // properties
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Name: {this.Name}, Price: {this.Price}";
        }
    }
}