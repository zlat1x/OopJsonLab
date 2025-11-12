using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace OopJsonLab.Models
{
    public class Book
    {
        [JsonPropertyName("PublishingHouseId")]
        public int PublishingHouseId { get; set; }

        [JsonPropertyName("Title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("PublishingHouse")]
        public PublishingHouse? PublishingHouse { get; set; }
    }
}