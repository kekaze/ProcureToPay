using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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
        [Required]
        public string Category { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [JsonIgnore]
        public ICollection<PurchaseRequest> PurchaseRequests { get; set; } = new List<PurchaseRequest>();
        [JsonIgnore]
        public ICollection<PurchaseRequestMaterial> PurchaseRequestMaterials { get; set; } = new List<PurchaseRequestMaterial>();
    }
}
