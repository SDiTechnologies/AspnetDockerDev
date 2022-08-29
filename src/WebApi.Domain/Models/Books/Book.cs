// using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
// using System.Text.Json;
// using System.Text.Json.Serialization;

using WebApi.Domain.Models.Common;
namespace WebApi.Domain.Models;

public class Book : BaseEntity
{
    // public Guid Id { get; set; }
    public string? Title { get; set; }
    // public string? ISBN { get; set; }
    public DateTime? ReleaseDate { get; set; }
    // public ICollection<Genre>? Genres { get; set; }
    // // Break off into seperate BookDetail for publisher and additional information; keep the database lean

    public IEnumerable<Author>? Authors { get; set; }

    [ForeignKey("Publisher")]
    public Guid PublisherId { get; set; }
    public Publisher? Publisher { get; set; }


    [ForeignKey("Location")]
    public Guid LocationId { get; set; }
    public Location? Location { get; set; }

    // [ForeignKey("Individual")]
    // public Guid IndividualId { get; set; }
    // public Individual? Individual { get; set; }



    // public ICollection<Genre>? Genres { get; set; }
    // public ICollection<Author>? Authors { get; set; }
    // public Publisher? Publisher { get; set; }
    // public DateTime Created
    // public DateTime Updated

    // // debug override ToString() method
    // public override string ToString()
    // {
    //     // system.text.json + system.text.json.serialization
    //     return JsonSerializer.Serialize(this);

    //     // // newtonsoft.json
    //     // return JsonConvert.SerializeObject(this);
    // }
}
