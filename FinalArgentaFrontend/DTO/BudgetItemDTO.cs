using System.ComponentModel.DataAnnotations;

namespace FinalArgentaFrontend.DTO
{
    public class BudgetItemDTO : RelatedDTO
    {
        [Required,
         MinLength(4, ErrorMessage = "Minimum length is 4."),
         MaxLength(10, ErrorMessage = "Maximum length is 10.")]
        public string Name { get; set; } = null!;

        [Required, Range(1, 100, ErrorMessage = "Percentage must be between 1 and 100")]
        public int Percentage { get; set; }

    }
}
