using System;
using System.Text.Json;

using WebApi.Domain.Models.Common;

namespace WebApi.Domain.Models;

// Library/Location related attributes
public class Address : BaseEntity
{
    public string? AddressLn1 { get; set; }
    public string? AddressLn2 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? PostalCode { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}
