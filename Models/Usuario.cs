using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace ApiPC3.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Email { get; set; }

        [JsonPropertyName("first_name")]
        public required string Nombre { get; set; }

        [JsonPropertyName("last_name")]
        public required string Apellido { get; set; }

        [JsonPropertyName("job")]
        public required string Trabajo { get; set; }
        public string? Avatar { get; set; }
    }
}