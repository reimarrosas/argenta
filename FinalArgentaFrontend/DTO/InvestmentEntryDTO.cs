using System.ComponentModel.DataAnnotations;

namespace FinalArgentaFrontend.DTO
{
    public class InvestmentEntryDTO : RelatedDTO
    {
        [Required, Range(1, int.MaxValue, ErrorMessage = "Count must be positive")]
        public int Count { get; set; }

        [Required, Range(1, double.MaxValue, ErrorMessage = "Unit Price must be positive")]
        public decimal UnitPrice { get; set; }

        public decimal TotalPrice => Count * UnitPrice;

        [Required]
        public string Ticker { get; set; } = null!;

    }
}
