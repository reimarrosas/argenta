using System.ComponentModel.DataAnnotations;

namespace FinalArgentaFrontend.DTO
{
    public class TransactionDTO : RelatedDTO
    {
        [Required, Range(0, double.MaxValue, ErrorMessage = "Input must not be negative.")]
        public decimal Input { get; set; }

        [Required, Range(0, double.MaxValue, ErrorMessage = "Output must not be negative.")]
        public decimal Output { get; set; }

        public string? Description { get; set; }
    }
}
