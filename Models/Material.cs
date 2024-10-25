using System.ComponentModel.DataAnnotations;

namespace ProcureToPay.Models
{
    public class Material
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
