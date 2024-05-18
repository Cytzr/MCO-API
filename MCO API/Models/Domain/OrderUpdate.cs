using System.Text.Json.Serialization;

namespace MCO_API.Models.Domain
{
    public class OrderUpdate
    {
        [JsonPropertyName("update")]
        public String? update {  get; set; }
    }
}
