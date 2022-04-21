namespace FinalArgentaBackend.Models
{
    public class GoalUpdate : RelatedEntity<Goal>
    {
        public decimal Payment { get; set; }

        public string? Note { get; set; }
    }
}
