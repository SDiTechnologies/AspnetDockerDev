using System.ComponentModel.DataAnnotations;

namespace WebApi.Data.Models.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
