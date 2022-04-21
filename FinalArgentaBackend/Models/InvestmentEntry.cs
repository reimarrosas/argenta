using System.Text.Json.Serialization;

namespace FinalArgentaBackend.Models
{
    public class InvestmentEntry : RelatedEntity<Investment>
    {
        public int Count { get; set; }

        public decimal UnitPrice { get; set; }

        [JsonIgnore]
        public decimal TotalPrice { get; set; } = 0M;

        public string Ticker { get; set; } = null!;
    }
}
