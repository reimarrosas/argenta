using System.ComponentModel.DataAnnotations;

namespace FinalArgentaFrontend.DTO
{
    public class GoalUpdateDTO : RelatedDTO
    {
        [Required,
         Range(0, double.MaxValue, ErrorMessage = "Payment should be positive.")]
        public decimal Payment { get; set; }

        public string? Note { get; set; }
    }
}
