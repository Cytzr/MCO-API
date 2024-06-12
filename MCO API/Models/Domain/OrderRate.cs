using System.Text.Json.Serialization;

namespace MCO_API.Models.Domain
{
    public class OrderRate
    {
        [JsonPropertyName("rating")]
        public int? rating { get; set; }
    }
}
