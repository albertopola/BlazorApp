using Newtonsoft.Json;
public class TodoItem
{
    [JsonProperty(PropertyName = "title")]
    public  string? Title { get; set; }
    [JsonProperty(PropertyName = "effort")]
    public decimal Effort {get; set;}
    [JsonProperty(PropertyName = "isdone")]
    public bool IsDone { get; set; }
}