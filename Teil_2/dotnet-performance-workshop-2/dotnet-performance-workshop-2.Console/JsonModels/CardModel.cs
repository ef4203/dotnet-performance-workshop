namespace EFK.DotnetPerformanceWorkshop.Part2.Console.JsonModels;

using System.Text.Json.Serialization;
using Newtonsoft.Json;

public class CardModel
{
    [JsonPropertyName("object")]
    public string? ObjectType { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("oracle_id")]
    public string? OracleId { get; set; }

    [JsonPropertyName("multiverse_ids")]
    public List<int>? MultiverseIds { get; set; }

    [JsonPropertyName("mtgo_id")]
    public int MtgoId { get; set; }

    [JsonPropertyName("mtgo_foil_id")]
    public int MtgoFoilId { get; set; }

    [JsonPropertyName("tcgplayer_id")]
    public int TcgPlayerId { get; set; }

    [JsonPropertyName("cardmarket_id")]
    public int CardmarketId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("lang")]
    public string? Lang { get; set; }

    [JsonPropertyName("released_at")]
    public string? ReleasedAt { get; set; }

    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    [JsonPropertyName("scryfall_uri")]
    public string? ScryfallUri { get; set; }

    [JsonPropertyName("layout")]
    public string? Layout { get; set; }

    [JsonPropertyName("highres_image")]
    public bool HighresImage { get; set; }

    [JsonPropertyName("image_status")]
    public string? ImageStatus { get; set; }

    [JsonPropertyName("image_uris")]
    public ImageUrisModel ImageUrisModel { get; set; } = new ();

    [JsonPropertyName("mana_cost")]
    [JsonProperty("mana_cost")]
    public string? ManaCost { get; set; }

    [JsonPropertyName("cmc")]
    public double Cmc { get; set; }

    [JsonPropertyName("type_line")]
    public string? TypeLine { get; set; }

    [JsonPropertyName("oracle_text")]
    public string? OracleText { get; set; }

    [JsonPropertyName("colors")]
    public List<object>? Colors { get; set; }

    [JsonPropertyName("color_identity")]
    public List<object>? ColorIdentity { get; set; }

    [JsonPropertyName("keywords")]
    public List<object>? Keywords { get; set; }

    [JsonPropertyName("legalities")]
    public LegalitiesModel LegalitiesModel { get; set; } = new ();

    [JsonPropertyName("games")]
    public List<string>? Games { get; set; }

    [JsonPropertyName("reserved")]
    public bool Reserved { get; set; }

    [JsonPropertyName("foil")]
    public bool Foil { get; set; }

    [JsonPropertyName("nonfoil")]
    public bool Nonfoil { get; set; }

    [JsonPropertyName("finishes")]
    public List<string?> Finishes { get; set; }

    [JsonPropertyName("oversized")]
    public bool Oversized { get; set; }

    [JsonPropertyName("promo")]
    public bool Promo { get; set; }

    [JsonPropertyName("reprint")]
    public bool Reprint { get; set; }

    [JsonPropertyName("variation")]
    public bool Variation { get; set; }

    [JsonPropertyName("set_id")]
    public string? MtgSetId { get; set; }

    [JsonPropertyName("set")]
    public string? Set { get; set; }

    [JsonPropertyName("set_name")]
    public string? MtgSetName { get; set; }

    [JsonPropertyName("set_type")]
    public string? MtgSetType { get; set; }

    [JsonPropertyName("set_uri")]
    public string? MtgSetUri { get; set; }

    [JsonPropertyName("set_search_uri")]
    public string? SetSearchUri { get; set; }

    [JsonPropertyName("scryfall_set_uri")]
    public string? ScryfallSetUri { get; set; }

    [JsonPropertyName("rulings_uri")]
    public string? RulingsUri { get; set; }

    [JsonPropertyName("prints_search_uri")]
    public string? PrintsSearchUri { get; set; }

    [JsonPropertyName("collector_number")]
    public string? CollectorNumber { get; set; }

    [JsonPropertyName("digital")]
    public bool Digital { get; set; }

    [JsonPropertyName("rarity")]
    public string? Rarity { get; set; }

    [JsonPropertyName("flavor_text")]
    public string? FlavorText { get; set; }

    [JsonPropertyName("card_back_id")]
    public string? CardBackId { get; set; }

    [JsonPropertyName("artist")]
    public string? Artist { get; set; }

    [JsonPropertyName("artist_ids")]
    public List<string>? ArtistIds { get; set; }

    [JsonPropertyName("illustration_id")]
    public string? IllustrationId { get; set; }

    [JsonPropertyName("border_color")]
    public string? BorderColor { get; set; }

    [JsonPropertyName("frame")]
    public string? Frame { get; set; }

    [JsonPropertyName("full_art")]
    public bool FullArt { get; set; }

    [JsonPropertyName("textless")]
    public bool Textless { get; set; }

    [JsonPropertyName("booster")]
    public bool Booster { get; set; }

    [JsonPropertyName("story_spotlight")]
    public bool StorySpotlight { get; set; }

    [JsonPropertyName("edhrec_rank")]
    public int EdhrecRank { get; set; }

    [JsonPropertyName("prices")]
    public PricesModel PricesModel { get; set; } = new ();

    [JsonPropertyName("related_uris")]
    public RelatedUrisModel RelatedUrisModel { get; set; } = new ();

    [JsonPropertyName("purchase_uris")]
    public PurchaseUrisModel PurchaseUrisModel { get; set; } = new ();
}
