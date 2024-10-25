using System.ComponentModel.DataAnnotations;

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
        public string Items { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
