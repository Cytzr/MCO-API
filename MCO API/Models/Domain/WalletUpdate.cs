using System.Text.Json.Serialization;

namespace MCO_API.Models.Domain
{
    public class WalletUpdate
    {
        [JsonPropertyName("value")]
        public int value { get; set; }
    }
}
