using WebApi.Domain.Models.Common.Recipes;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Models;

public class Ingredient : BaseEntity
{
    public string? Name { get; set; }
    public int Amount { get; set; }
    [ForeignKey("Recipe")]
    public int RecipeId { get; set; }
    public Recipe? Recipe { get; set; }
}
