using ProcureToPay.Models;
using System.ComponentModel.DataAnnotations;

namespace ProcureToPay.DTOs
{
    public class ModelDtos
    {
        public class SinglePurchaseRequestDto
        {
            public int PurchaseId { get; set; }
            public string Purpose { get; set; } = string.Empty;
            public string Type { get; set; } = string.Empty;
            public string Status { get; set; } = string.Empty;
            public DateTime CreatedAt { get; set; }
            public string CompanyId { get; set; } = string.Empty;
            public string CompanyName { get; set; } = string.Empty;
            public ICollection<MaterialsDto> Materials { get; set; } = new List<MaterialsDto>();
        }

        public class MaterialsDto
        {
            public int MaterialCode { get; set; }
            public string MaterialName { get; set; } = string.Empty;
            public float Quantity { get; set; }
        }
    }
}
