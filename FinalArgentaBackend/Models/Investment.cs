namespace FinalArgentaBackend.Models
{
    public class Investment : RelatedEntity<Users>
    {
        public string? Description { get; set; }
    }
}
