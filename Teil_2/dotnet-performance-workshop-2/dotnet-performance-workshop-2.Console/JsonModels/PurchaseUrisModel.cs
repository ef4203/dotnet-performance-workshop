namespace EFK.DotnetPerformanceWorkshop.Part2.Console.JsonModels;

using System.Text.Json.Serialization;

public class PurchaseUrisModel
{
    [JsonPropertyName("tcgplayer")]
    public string? TcgPlayer { get; set; }

    [JsonPropertyName("cardmarket")]
    public string? Cardmarket { get; set; }

    [JsonPropertyName("cardhoarder")]
    public string? Cardhoarder { get; set; }
}
