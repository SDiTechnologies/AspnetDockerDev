using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using WebApi.Domain.Models.Common;
namespace WebApi.Domain.Models;

public class Individual : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Alias { get; set; }
    public DateTime? DateOfBirth { get; set; }

    // public ICollection<Location>? Locations { get; set; }

}
