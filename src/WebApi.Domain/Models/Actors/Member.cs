using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using WebApi.Domain.Models.Common;
namespace WebApi.Domain.Models;

public class Member : Individual
{
    // public string? FirstName { get; set; }
    // public string? LastName { get; set; }

    [ForeignKey("Location")]
    public Guid LocationId { get; set; }
    public Location? Location { get; set; }

}
