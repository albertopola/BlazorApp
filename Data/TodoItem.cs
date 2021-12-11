using Newtonsoft.Json;
public class TodoItem
{
    [JsonProperty(PropertyName = "title")]
    public  string? Title { get; set; }

    [JsonProperty(PropertyName = "isdone")]
    public bool IsDone { get; set; }
    [JsonProperty(PropertyName = "asset")]
    public List<Asset> Assets {get; set;}
    public class Asset
    {
        [JsonProperty(PropertyName ="assetname")]
        public string AssetName {get; set;}
        [JsonProperty(PropertyName = "asseteffort")]
        public decimal AssetEffort {get; set;}
    }
}