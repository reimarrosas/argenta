namespace FinalArgentaBackend.Models
{
    public class BudgetItem : RelatedEntity<Budget>
    {
        public string Name { get; set; } = null!;

        public int Percentage { get; set; }
    }
}
