using System;
using System.Collections.Generic;

namespace InsideAirBNB.Models
{
    public partial class Calendar
    {
        public int ListingId { get; set; }
        public DateTime Date { get; set; }
        public string Available { get; set; }
        public string Price { get; set; }

        public virtual Listings Listing { get; set; }
    }
}
