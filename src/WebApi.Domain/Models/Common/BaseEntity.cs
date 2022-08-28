using System.ComponentModel.DataAnnotations;

namespace WebApi.Domain.Models.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
