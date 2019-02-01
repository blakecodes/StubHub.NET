using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Stubhub.ClientLibrary.Models.Categories
{
    public partial class SearchCategories
    {
        [JsonProperty("numFound")]
        public long NumFound { get; set; }

        [JsonProperty("groupings")]
        public Grouping[] Groupings { get; set; }
    }

    public partial class Grouping
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("parentId")]
        public long ParentId { get; set; }

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

        [JsonProperty("ancestors")]
        public Ancestor[] Ancestors { get; set; }

        [JsonProperty("categories")]
        public Ancestor[] Categories { get; set; }

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

    public partial class Ancestor
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("webURI", NullValueHandling = NullValueHandling.Ignore)]
        public string WebUri { get; set; }

        [JsonProperty("seoURI", NullValueHandling = NullValueHandling.Ignore)]
        public string SeoUri { get; set; }
    }

    public partial class DisplayAttributes
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("hiddenInd")]
        public bool HiddenInd { get; set; }
    }
}
