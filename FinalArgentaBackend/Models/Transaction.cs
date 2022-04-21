namespace FinalArgentaBackend.Models
{
    public class Transaction : RelatedEntity<Users>
    {
        public decimal Input { get; set; }

        public decimal Output { get; set; }

        public string? Description { get; set; }
    }
}
