// using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

using WebApi.Domain.Models.Common;
namespace WebApi.Domain.Models;

public class Organization : BaseEntity
{
    [JsonPropertyName("orgName")]
    public string? OrganizationName { get; set; }
    [JsonPropertyName("orgAlias")]
    public string? OrganizationAlias { get; set; }
    [JsonPropertyName("orgSlogan")]
    public string? OrganizationSlogan { get; set; }

    public IEnumerable<Location>? Locations { get; set; }

    // debug override ToString() method
    public override string ToString()
    {
        // system.text.json + system.text.json.serialization
        return JsonSerializer.Serialize(this);

        // // newtonsoft.json
        // return JsonConvert.SerializeObject(this);
    }

}
