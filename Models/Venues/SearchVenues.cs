using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Stubhub.ClientLibrary.Models.Events;

namespace Stubhub.ClientLibrary.Models.Venues
{
    public partial class SearchVenues
    {
        [JsonProperty("numFound")]
        public long NumFound { get; set; }

        [JsonProperty("venues")]
        public List<Venue> Venues { get; set; }
    }

    public partial class Venue
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("webURI")]
        public string WebUri { get; set; }

        [JsonProperty("seoURI")]
        public string SeoUri { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("jdkTimezone")]
        public string JdkTimezone { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("geos")]
        public Category[] Geos { get; set; }

        [JsonProperty("categories")]
        public Category[] Categories { get; set; }

        [JsonProperty("displayAttributes")]
        public DisplayAttributes DisplayAttributes { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("lastUpdatedDate")]
        public string LastUpdatedDate { get; set; }

        [JsonProperty("defaultLocale")]
        public string DefaultLocale { get; set; }
        
    }

    public partial class Address
    {
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }
    }
}
