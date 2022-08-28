using System.ComponentModel.DataAnnotations;

namespace WebApi.Domain.Models.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
