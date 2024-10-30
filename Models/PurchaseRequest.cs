using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProcureToPay.Models
{
    public class PurchaseRequest
    {
        public int Id { get; set; }
        [Required]
        public int PurchaseId { get; set; }
        [Required]
        public string Purpose { get; set; } = string.Empty;
        [Required]
        public string Type { get; set; } = string.Empty;
        [Required]
        public string Status { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<Material> Materials { get; set; } = new List<Material>();
    }
}
