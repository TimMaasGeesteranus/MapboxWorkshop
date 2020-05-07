using System;
using System.Collections.Generic;

namespace InsideAirBNB.Models
{
    public partial class Reviews
    {
        public int ListingId { get; set; }
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ReviewerId { get; set; }
        public string ReviewerName { get; set; }
        public string Comments { get; set; }

        public virtual Listings Listing { get; set; }
    }
}
