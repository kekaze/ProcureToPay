using System.ComponentModel.DataAnnotations;

namespace ProcureToPay.Models
{
    public class Material
    {
        public int Id { get; set; }
        public int MaterialCode { get; set; }
        [Required]
        public string MaterialName { get; set; } = string.Empty;
        [Required]
        public string Brand { get; set; } = string.Empty;
        [Required]
        public string Dimensions { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<PurchaseRequest> PurchaseRequests { get; set; } = new List<PurchaseRequest>();
    }
}
