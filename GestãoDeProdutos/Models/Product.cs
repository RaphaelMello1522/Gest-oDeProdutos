using System;
using System.ComponentModel.DataAnnotations;

namespace GestãoDeProdutos.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Insira o nome do produto!")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$")]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime SellDate { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
    }
}
