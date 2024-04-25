namespace EFK.DotnetPerformanceWorkshop.Part2.Console.JsonModels;

using System.Text.Json.Serialization;

public class PricesModel
{
    [JsonPropertyName("usd")]
    public string? Usd { get; set; }

    [JsonPropertyName("usd_foil")]
    public object? UsdFoil { get; set; }

    [JsonPropertyName("usd_etched")]
    public object? UsdEtched { get; set; }

    [JsonPropertyName("eur")]
    public string? Eur { get; set; }

    [JsonPropertyName("eur_foil")]
    public object? EurFoil { get; set; }

    [JsonPropertyName("tix")]
    public string? Tix { get; set; }
}
