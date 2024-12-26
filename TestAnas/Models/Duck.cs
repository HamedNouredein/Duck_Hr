using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestAnas.Models
{
    public class Duck : BaseEntity
    {
        [Required]
        public string Name { get; set; } = "";

        [Required]
        public decimal Weight { get; set; }

        public string? Notes { get; set; }

        [Required]
        public int CycleId { get; set; }

        [ForeignKey(nameof(CycleId))]
        public Cycle Cycle { get; set; }
    }
}
