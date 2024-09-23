using System;
using System.Text.Json.Serialization;

namespace RandomApiUser.Models;

public class Employment
{
    [JsonPropertyName("title")]
    public string? Title {get; set;}

    [JsonPropertyName("key_kill")]
    public string? KeyKill {get; set;}
}
