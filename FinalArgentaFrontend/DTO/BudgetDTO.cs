using System.ComponentModel.DataAnnotations;

namespace FinalArgentaFrontend.DTO
{
    public class BudgetDTO : RelatedDTO
    {
        [Required,
         MinLength(4, ErrorMessage = "Minimum length is 4.")]
        public string Name { get; set; } = null!;

        [Required, Range(0, double.MaxValue, ErrorMessage = "Total must not be negative.")]
        public decimal Total { get; set; }

        public string? Description { get; set; }
    }
}
