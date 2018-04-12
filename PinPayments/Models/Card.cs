using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PinPayments.Models
{
    [DataContract]
    public class CardCreateResponse : PinError
    {
        [DataMember(Name = "response")]
        public Card Card { get; set; }
    }

    [DataContract(Name = "card")]
    public class Card
    {
        [DataMember(Name = "token")]
        public string Token { get; set; }

        [DataMember(Name = "number")]
        public string CardNumber { get; set; }

        [DataMember(Name = "cvc")]
        public string CVC { get; set; }

        [DataMember(Name = "display_number")]
        public string DisplayNumber { get; set; }

        [DataMember(Name = "expiry_month")]
        public string ExpiryMonth { get; set; }

        [DataMember(Name = "expiry_year")]
        public string ExpiryYear { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "address_line1")]
        public string Address1 { get; set; }

        [DataMember(Name = "address_line2")]
        public string Address2 { get; set; }

        [DataMember(Name = "address_city")]
        public string City { get; set; }

        [DataMember(Name = "address_postcode")]
        public string Postcode { get; set; }

        [DataMember(Name = "address_state")]
        public string State { get; set; }

        [DataMember(Name = "address_country")]
        public string Country { get; set; }

        [DataMember(Name = "scheme")]
        public string Scheme { get; set; }

        [DataMember(Name = "publishable_api_key")]
        public string APIKey { get; set; }

        [DataMember(Name = "card_token")]
        public string CardToken { get; set; }

        [DataMember(Name = "customer_token")]
        public string CustomerToken { get; set; }
    }
}
