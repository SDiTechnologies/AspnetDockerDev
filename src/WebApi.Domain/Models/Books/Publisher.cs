using System.Text.Json;
using System.Text.Json.Serialization;

using WebApi.Domain.Models.Common;

namespace WebApi.Domain.Models;


public class Publisher : BaseEntity
{
    // public Guid Id { get; set; }
    public string? PublisherName { get; set; }
    // Some measure of a collection of books?

    // // debug override ToString() method
    // public override string ToString()
    // {
    //     // system.text.json + system.text.json.serialization
    //     return JsonSerializer.Serialize(this);

    //     // // newtonsoft.json
    //     // return JsonConvert.SerializeObject(this);
    // }
}
