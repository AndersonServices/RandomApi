using System;
using System.Text.Json.Serialization;

namespace RandomApiUser.Models;

public class CreditCard
{
    [JsonPropertyName("cc_number")]
    public string? CreditCardNumber{get; set;}
}
