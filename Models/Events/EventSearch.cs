using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Stubhub.ClientLibrary.Models.Venues;

namespace Stubhub.ClientLibrary.Models.Events
{
    public partial class EventSearch
    {
        [JsonProperty("numFound")]
        public long NumFound { get; set; }

        [JsonProperty("events")]
        public List<Event> Events { get; set; }
    }

    public partial class Event
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("originalName")]
        public string OriginalName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("webURI")]
        public string WebUri { get; set; }

        [JsonProperty("seoURI")]
        public string SeoUri { get; set; }

        [JsonProperty("eventDateLocal")]
        public string EventDateLocal { get; set; }

        [JsonProperty("eventDateUTC")]
        public string EventDateUtc { get; set; }

        [JsonProperty("venue")]
        public Venue Venue { get; set; }

        [JsonProperty("venueConfiguration")]
        public VenueConfiguration VenueConfiguration { get; set; }

        [JsonProperty("bobId")]
        public long BobId { get; set; }

        [JsonProperty("ancestors")]
        public Ancestors Ancestors { get; set; }

        [JsonProperty("sourceId")]
        public long SourceId { get; set; }

        [JsonProperty("associatedEvents")]
        public object[] AssociatedEvents { get; set; }

        [JsonProperty("categories")]
        public Category[] Categories { get; set; }

        [JsonProperty("groupings")]
        public Category[] Groupings { get; set; }

        [JsonProperty("performers")]
        public Category[] Performers { get; set; }

        [JsonProperty("geos")]
        public Category[] Geos { get; set; }

        [JsonProperty("categoriesCollection")]
        public Category[] CategoriesCollection { get; set; }

        [JsonProperty("performersCollection")]
        public Category[] PerformersCollection { get; set; }

        [JsonProperty("imageUrl")]
        public Uri ImageUrl { get; set; }

        [JsonProperty("images")]
        public Image[] Images { get; set; }

        [JsonProperty("displayAttributes")]
        public DisplayAttributes DisplayAttributes { get; set; }

        [JsonProperty("mobileAttributes")]
        public MobileAttributes MobileAttributes { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("lastUpdatedDate")]
        public string LastUpdatedDate { get; set; }

        [JsonProperty("defaultLocale")]
        public string DefaultLocale { get; set; }

        [JsonProperty("catalogTemplate")]
        public CatalogTemplate CatalogTemplate { get; set; }

        [JsonProperty("eventExternalUrls")]
        public object[] EventExternalUrls { get; set; }

        [JsonProperty("eventAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public EventAttributes EventAttributes { get; set; }

        [JsonProperty("dateTrueOnsale", NullValueHandling = NullValueHandling.Ignore)]
        public string DateTrueOnsale { get; set; }

        [JsonProperty("groupingsCollection", NullValueHandling = NullValueHandling.Ignore)]
        public Category[] GroupingsCollection { get; set; }
    }

    public partial class Ancestors
    {
        [JsonProperty("categories")]
        public Category[] Categories { get; set; }

        [JsonProperty("groupings")]
        public Category[] Groupings { get; set; }

        [JsonProperty("performers")]
        public Category[] Performers { get; set; }

        [JsonProperty("geos")]
        public Category[] Geos { get; set; }
    }

    public partial class Category
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("originalName", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalName { get; set; }

        [JsonProperty("webURI", NullValueHandling = NullValueHandling.Ignore)]
        public string WebUri { get; set; }

        [JsonProperty("seoURI", NullValueHandling = NullValueHandling.Ignore)]
        public string SeoUri { get; set; }

        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }
    }

    public partial class CatalogTemplate
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class DisplayAttributes
    {
        [JsonProperty("isHidden")]
        public bool IsHidden { get; set; }

        [JsonProperty("hideEventDate")]
        public bool HideEventDate { get; set; }

        [JsonProperty("hideEventTime")]
        public bool HideEventTime { get; set; }

        [JsonProperty("primaryName")]
        public string PrimaryName { get; set; }
    }

    public partial class EventAttributes
    {
        [JsonProperty("parkingEventIds")]
        public long[] ParkingEventIds { get; set; }
    }

    public partial class Image
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("isResizable")]
        public bool IsResizable { get; set; }

        [JsonProperty("urlSsl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri UrlSsl { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        [JsonProperty("credit")]
        public string Credit { get; set; }

        [JsonProperty("regionOfInterest", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionOfInterest { get; set; }
    }

    public partial class MobileAttributes
    {
        [JsonProperty("enableApplePassbook")]
        public bool EnableApplePassbook { get; set; }

        [JsonProperty("mobileListingNotAllowed")]
        public bool MobileListingNotAllowed { get; set; }

        [JsonProperty("stubhubMobileTicket")]
        public bool StubhubMobileTicket { get; set; }
    }
    
    public partial class VenueConfiguration
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gaIndicator")]
        public bool GaIndicator { get; set; }
    }

}
