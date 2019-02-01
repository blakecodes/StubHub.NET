using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stubhub.ClientLibrary.Models.Inventory
{
    public partial class InventorySearch
    {
        [JsonProperty("eventId")]
        public long EventId { get; set; }

        [JsonProperty("totalListings")]
        public long TotalListings { get; set; }

        [JsonProperty("totalTickets")]
        public int TotalTickets { get; set; }

        [JsonProperty("minQuantity")]
        public long MinQuantity { get; set; }

        [JsonProperty("maxQuantity")]
        public long MaxQuantity { get; set; }

        [JsonProperty("listing")]
        public Listing[] Listing { get; set; }

        [JsonProperty("listingAttributeCategorySummary")]
        public object[] ListingAttributeCategorySummary { get; set; }

        [JsonProperty("deliveryTypeSummary")]
        public object[] DeliveryTypeSummary { get; set; }

        [JsonProperty("start")]
        public long Start { get; set; }

        [JsonProperty("rows")]
        public long Rows { get; set; }
    }

    public partial class Listing
    {
        [JsonProperty("listingId")]
        public long ListingId { get; set; }

        [JsonProperty("currentPrice")]
        public CurrentPrice CurrentPrice { get; set; }

        [JsonProperty("listingPrice")]
        public CurrentPrice ListingPrice { get; set; }

        [JsonProperty("sectionId")]
        public long SectionId { get; set; }

        [JsonProperty("row")]
        public string Row { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("sellerSectionName")]
        public string SellerSectionName { get; set; }

        [JsonProperty("sectionName")]
        public string SectionName { get; set; }

        [JsonProperty("zoneId")]
        public long ZoneId { get; set; }

        [JsonProperty("zoneName")]
        public string ZoneName { get; set; }

        [JsonProperty("businessGuid", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessGuid { get; set; }

        [JsonProperty("listingAttributeList", NullValueHandling = NullValueHandling.Ignore)]
        public long[] ListingAttributeList { get; set; }

        [JsonProperty("deliveryTypeList")]
        public long[] DeliveryTypeList { get; set; }

        [JsonProperty("deliveryMethodList")]
        public long[] DeliveryMethodList { get; set; }

        [JsonProperty("isGA")]
        public long IsGa { get; set; }

        [JsonProperty("dirtyTicketInd")]
        public bool DirtyTicketInd { get; set; }

        [JsonProperty("splitOption")]
        public long SplitOption { get; set; }

        [JsonProperty("ticketSplit")]
        public long TicketSplit { get; set; }

        [JsonProperty("splitVector")]
        public long[] SplitVector { get; set; }

        [JsonProperty("sellerOwnInd")]
        public long SellerOwnInd { get; set; }

        [JsonProperty("faceValue", NullValueHandling = NullValueHandling.Ignore)]
        public CurrentPrice FaceValue { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("seatNumbers", NullValueHandling = NullValueHandling.Ignore)]
        public string SeatNumbers { get; set; }
    }

    public partial class CurrentPrice
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

}
