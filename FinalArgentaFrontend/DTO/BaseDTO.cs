namespace FinalArgentaFrontend.DTO
{
    public class BaseDTO
    {
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
