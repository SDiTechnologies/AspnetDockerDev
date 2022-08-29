// using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

using WebApi.Domain.Models.Common;
namespace WebApi.Domain.Models;

public class Organization : BaseEntity
{
    public string? OrganizationName { get; set; }
    public string? OrganizationAlias { get; set; }

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
