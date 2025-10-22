using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tulip.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required, StringLength(200)]
        public string ProductName { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Column(TypeName = "decimal(12,2)")]
        public decimal Price { get; set; }

        public int Stock { get; set; }

        [StringLength(100)]
        public string? Category { get; set; }

        [StringLength(255)]
        public string? ImageURL { get; set; }

        // Quan hệ
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
