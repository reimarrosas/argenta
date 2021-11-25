namespace FinalArgentaBackend.Models
{
    public class Budget : RelatedEntity<Users>
    {
        public string Name { get; set; } = null!;

        public decimal Total { get; set; }

        public string? Description { get; set; }
    }
}
