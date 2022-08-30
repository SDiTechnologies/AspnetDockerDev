using System.ComponentModel.DataAnnotations;

namespace WebApi.Domain.Models.Common.Recipes
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
