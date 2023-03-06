using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CQRS.Models
{
    public class Product
    {
        public Guid Id { get; set; }

        [StringLength(80, MinimumLength = 4)]
        public string? Name { get; set; }

        [StringLength(80, MinimumLength = 4)]
        public string? Description { get; set; }

        [StringLength(80, MinimumLength = 4)]
        public string? Category { get; set; }

        public bool Active { get; set; } = true;

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
    }
}
