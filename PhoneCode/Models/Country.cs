using Newtonsoft.Json;
using System.Collections.Generic;

namespace PhoneCode.Models
{
    public class Country
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("countryCode")]
        public int CountryCode { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("countryIso")]
        public string CountryIso { get; set; }

        public string phoneNumber { get; set; } 
        [JsonIgnore]
        public virtual ICollection<CountryDetail> CountryDetails { get; set; }
    }
}
