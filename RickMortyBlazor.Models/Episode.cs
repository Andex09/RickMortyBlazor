using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RickMortyBlazor.Models
{
    public class Episode
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonPropertyName("air_date")]
        public string AirDate { get; set; }

        [JsonPropertyName("episode")]
        public string EpisodeCode { get; set; }
        public string Url { get; set; }
        public DateTime Created { get; set; }
    }
}
