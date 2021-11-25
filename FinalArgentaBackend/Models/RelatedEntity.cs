using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FinalArgentaBackend.Models
{
    public class RelatedEntity<T> : BaseEntity where T : BaseEntity
    {
        public Guid BaseId { get; set; }

        [JsonIgnore]
        public T Base { get; set; } = default!;
    }
}
