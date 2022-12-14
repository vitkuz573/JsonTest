using System.Text.Json.Serialization;

namespace JsonTest.Models;

public class UserInfo
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
}


