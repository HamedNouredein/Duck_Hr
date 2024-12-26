using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestAnas.Models
{
    public class Cycle : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = "";
        [Required]
        public DateTime BirthDate { get; set; }
        public string? Notes { get; set; }
        public ICollection<Duck> Ducks { get; set; } = [];
        public ICollection<CycleVaccine> CycleVaccines { get; set; } = [];
        public int FarmId { get; set; }
        [ForeignKey(nameof(FarmId))]
        public Farm Farm { get; set; }
    }
}
