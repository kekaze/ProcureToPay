using System.Text.Json.Serialization;

namespace ProcureToPay.Models
{
    public class PurchaseRequestMaterial
    {
        public int PurchaseRequestId { get; set; }
        [JsonIgnore]
        public PurchaseRequest? PurchaseRequest { get; set; }

        public int MaterialId { get; set; }
        [JsonIgnore]
        public Material? Material { get; set; }

        public float Quantity { get; set; }
    }
}
