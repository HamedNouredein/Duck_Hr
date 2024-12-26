using System.ComponentModel.DataAnnotations;

namespace TestAnas.Models
{
    public class Farm : BaseEntity
    {
        [Required]
        public string Name { get; set; } = "";
        [Required]
        public string Location { get; set; } = "";
        public string? Notes { get; set; }
        public ICollection<Cycle> Cycles { get; set; } = [];

    }
}
