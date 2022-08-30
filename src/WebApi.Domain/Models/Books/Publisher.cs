using System.Text.Json;

using WebApi.Domain.Models.Common;

namespace WebApi.Domain.Models;


public class Publisher : BaseEntity
{
    public string? PublisherName { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}
