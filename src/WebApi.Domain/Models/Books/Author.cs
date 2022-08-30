using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

using WebApi.Domain.Models.Common;

namespace WebApi.Domain.Models;


public class Author : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    // Some measure of a collection of books?

    [ForeignKey("Book")]
    public Guid BookId { get; set; }
    public Book? Book { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}
