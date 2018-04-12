using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PinPayments.Actions
{
    [DataContract]
    public class Pagination
    {

        [DataMember(Name = "current")]
        public int Current { get; set; }

        [DataMember(Name = "previous")]
        public int? Previous { get; set; }

        [DataMember(Name = "next")]
        public int? Next { get; set; }

        [DataMember(Name = "per_page")]
        public int PageSize { get; set; }

        [DataMember(Name = "pages")]
        public int? Pages { get; set; }

        [DataMember(Name = "count")]
        public int Count { get; set; }

    }
}
