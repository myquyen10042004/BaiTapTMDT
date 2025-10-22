using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tulip.Models
{
    [Table("TransactionLog")]
    public class TransactionLog
    {
        [Key]
        public int LogID { get; set; }

        [ForeignKey("Order")]
        public int? OrderID { get; set; }

        [ForeignKey("Payment")]
        public int? PaymentID { get; set; }

        public DateTime LogDate { get; set; } = DateTime.Now;

        [StringLength(100)]
        public string? ActionType { get; set; }

        public string? Description { get; set; }

        [StringLength(50)]
        public string? Status { get; set; }

        [StringLength(500)]
        public string? ErrorMessage { get; set; }

        // Quan hệ
        public Order? Order { get; set; }
        public Payment? Payment { get; set; }
    }
}
