using WebApi.Domain.Models.Common;
using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Models;

public class User : BaseEntity
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public IEnumerable<Recipe>? Recipes { get; set; }
}
