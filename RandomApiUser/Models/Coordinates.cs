using System;
using System.Text.Json.Serialization;

namespace RandomApiUser.Models;

public class Coordinates
{
    [JsonPropertyName("lat")]
    public double? Latitude {get; set;}

    [JsonPropertyName("lng")]
    public double? Longitude {get; set;}
}
