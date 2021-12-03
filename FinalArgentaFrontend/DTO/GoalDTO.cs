using System.ComponentModel.DataAnnotations;

namespace FinalArgentaFrontend.DTO
{
    public class GoalDTO : RelatedDTO
    {
        [Required,
         MinLength(4, ErrorMessage = "Minimum length is 4.")]
        public string Name { get; set; } = null!;

        public string? Description { get; set; }

        [Required,
         Range(0, double.MaxValue, ErrorMessage = "Value must be positive.")]
        public decimal Value { get; set; }

        [Required,
         Range(0, double.MaxValue, ErrorMessage = "APR must be positive.")]
        public decimal APR { get; set; }
    }
}
