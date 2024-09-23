using System;
using System.Text.Json.Serialization;

namespace RandomApiUser.Models;

public class User
{
    [JsonPropertyName("id")]
    public int Id {get; set;}

    [JsonPropertyName("uid")]
    public string? UId {get; set;}

    [JsonPropertyName("password")]
    public string? Password {get; set;}

    [JsonPropertyName("first_name")]
    public string? FirstName{get; set;}

    [JsonPropertyName("last_name")]
    public string? LastName{get; set;}

    [JsonPropertyName("username")]
    public string? UserName{get; set;}

    [JsonPropertyName("email")]
    public string? Email{get; set;}

    [JsonPropertyName("avatar")]
    public string? Avatar{get; set;}

    [JsonPropertyName("gender")]
    public string? Gender{get; set;}

    [JsonPropertyName("phone_number")]
    public string? PhoneNumber{get; set;}

    [JsonPropertyName("social_insurance_number")]
    public string? SocialInsurenceNumber{get; set;}

    [JsonPropertyName("date_of_birth")]
    public string? DateOfBirth{get; set;}

    [JsonPropertyName("employment")]
    public Employment? EmploymentUser{get;set;}

    [JsonPropertyName("address")]
    public Address? AddressUser{get; set;}

    [JsonPropertyName("credit_card")]
    public CreditCard? CreditCardUser{get; set;}

    [JsonPropertyName("subscription")]
    public Subscription? SubscriptionUser {get; set;}
}
