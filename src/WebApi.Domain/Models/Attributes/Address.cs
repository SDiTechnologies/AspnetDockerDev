using System.Text.Json;
using System.Text.Json.Serialization;

namespace WebApi.Domain.Models;

// Library/Location related attributes
public class Address
{
    public Address() { }

    public Address(string addressLn1, string addressLn2, string city, string state, string postalCode)
    {
        AddressLn1 = addressLn1;
        AddressLn2 = addressLn2;
        City = city;
        State = state;
        PostalCode = postalCode;
    }

    public Guid Id { get; set; }
    public string? AddressLn1 { get; set; }
    public string? AddressLn2 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? PostalCode { get; set; }

    // debug override ToString() method
    public override string ToString()
    {
        // system.text.json + system.text.json.serialization
        return JsonSerializer.Serialize(this);

        // // newtonsoft.json
        // return JsonConvert.SerializeObject(this);
    }
}
