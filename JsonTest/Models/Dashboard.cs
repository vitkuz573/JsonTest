using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace JsonTest.Models;

public class Dashboard
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("users")]
    public List<Dictionary<string, UserInfo>> Users { get; set; }
}
