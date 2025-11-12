using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace OopJsonLab.Models
{
    public class Book
    {
        [JsonIgnore]
        public int PublishingHouseId { get; set; }

        [JsonPropertyName("Name")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("PublishingHouse")]
        public PublishingHouse? PublishingHouse { get; set; }
    }
}