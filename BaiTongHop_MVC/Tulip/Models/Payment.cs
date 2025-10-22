using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tulip.Models
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }

        [ForeignKey("Order")]
        public int OrderID { get; set; }

        public DateTime PaymentDate { get; set; } = DateTime.Now;

        [StringLength(50)]
        public string? PaymentStatus { get; set; }

        [StringLength(100)]
        public string? TransactionCode { get; set; }

        // Quan hệ
        public Order? Order { get; set; }
        public ICollection<TransactionLog>? TransactionLogs { get; set; }
    }
}
