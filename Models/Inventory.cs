using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProcureToPay.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        [Required]
        public int CompanyId { get; set; }
        [JsonIgnore]
        public virtual Company? Company { get; set; }
        [Required]
        public decimal Quantity { get; set; }
        [Required]
        public decimal LatestPrice { get; set; }
        [Required]
        public int MaterialId { get; set; }
        [JsonIgnore]
        public virtual Material? Material { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
