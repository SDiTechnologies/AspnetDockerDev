using System;
using System.Text.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using WebApi.Domain.Models.Common;
namespace WebApi.Domain.Models;

public class Location : BaseEntity
{
    public string? LocationName { get; set; }
    public string? LocationAlias { get; set; }
    public IEnumerable<Book>? Books { get; set; }
    // public IEnumerable<Member>? Members { get; set; }

    [ForeignKey("Address")]
    public Guid AddressId { get; set; }
    public Address? Address { get; set; }

    // [ForeignKey("Individual")]
    // public Guid IndividualId { get; set; }
    // public Individual? Individual { get; set; }

    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }
    public Organization? Organization { get; set; }

    public override string ToString()
    {
        // system.text.json + system.text.json.serialization
        return JsonSerializer.Serialize(this);

        // // newtonsoft.json
        // return JsonConvert.SerializeObject(this);
    }

}
