using System.ComponentModel.DataAnnotations;

namespace AlfaRec.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        [Required]
        [Range(0.01,double.MaxValue)]
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Product()
        {

        }
    }
}
