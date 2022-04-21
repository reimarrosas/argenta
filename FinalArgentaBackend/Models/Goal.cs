using System.ComponentModel.DataAnnotations;

namespace FinalArgentaBackend.Models
{
    public class Goal : RelatedEntity<Users>
    {
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Value { get; set; }

        [Range(0, double.MaxValue)]
        public decimal APR { get; set; }
    }
}
