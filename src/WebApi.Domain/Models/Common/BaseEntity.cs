using System;
using System.Text.Json;

using System.ComponentModel.DataAnnotations;

namespace WebApi.Domain.Models.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public override string ToString()
        {
            // system.text.json + system.text.json.serialization
            return JsonSerializer.Serialize(this);

            // // newtonsoft.json
            // return JsonConvert.SerializeObject(this);
        }
    }
}
