using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace OopJsonLab.Models
{
    public class PublishingHouse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("Adress")]
        public string Address { get; set; } = string.Empty;
    }
}