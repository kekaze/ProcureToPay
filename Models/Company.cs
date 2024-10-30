using System.ComponentModel.DataAnnotations;

namespace ProcureToPay.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyId { get; set; } = string.Empty;
        public string CompanyName { get; set;} = string.Empty;
        [Required]
        public string Status { get; set; } = "Active";
        public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();
    }
}
