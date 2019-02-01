using Modsi.QueryAttribute;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stubhub.ClientLibrary.Transfer.Events
{
    public class EventSearchRequest
    {
        [QueryAttribute("q", true, null)]
        public string Q { get; set; }

        [QueryAttribute("city", true, "")]
        public string City { get; set; }

        [QueryAttribute("state", true, "")]
        public string State { get; set; }

        [QueryAttribute("country", true, "")]
        public string Country { get; set; }

        [QueryAttribute("postalCode", true, "")]
        public string PostalCode { get; set; }

        [QueryAttribute("point", true, "")]
        public string Point { get; set; }

        [QueryAttribute("radius", true, null)]
        public string Radius { get; set; }

        [QueryAttribute("units", true, null)]
        public string Units { get; set; }

        [QueryAttribute("minAvailableTickets", true, "0")]
        public int MinAvailableTickets { get; set; }

        [QueryAttribute("minPrice", true, "0")]
        public int MinPrice { get; set; }

        [QueryAttribute("parking", true, "False")]
        public bool Parking { get; set; }

        [QueryAttribute("start", true, "0")]
        public int Start { get; set; }

        [QueryAttribute("rows", true, "0")]
        public int Rows { get; set; }

        [QueryAttribute("fieldList", true, null)]
        public string FieldList { get; set; }
    }
}
