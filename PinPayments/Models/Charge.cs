using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using PinPayments.Actions;

namespace PinPayments.Models
{
    [DataContract]
    public class Charges:PinError
    {
        public Charge[] Response { get; set; }
        public int Count { get; set; }
        public Pagination Pagination { get; set; }
    }

    [DataContract]
    public class ChargeResponse:PinError
    {
         [DataMember(Name = "response")]
        public Charge Charge{ get; set; }
    }

    [DataContract]
    public class PostCharge
    {
        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "amount")]
        public long Amount { get; set; }

        [DataMember(Name = "ip_address")]
        public string IPAddress { get; set; }

        private string _currency { get; set; }

        [DataMember(Name = "currency")]
        public string Currency
        {
            get
            {
                if (_currency == null)
                {
                    return "AUD";
                }
                return _currency;
            }
            set { _currency = value; }
        }

        [IgnoreDataMember]
        public Card Card { get; set; }

        [IgnoreDataMember]
        public string CardToken { get; set; }

        [IgnoreDataMember]
        public string CustomerToken { get; set; }

    }

    public class ChargeDetail
    {
        public Charge Response { get; set; }
    }
    [DataContract]
    public class Charge
    {
        [DataMember(Name = "token")]
        public string Token { get; set; }

        [DataMember(Name = "success")]
        public bool Success { get; set; }

        [DataMember(Name = "amount")]
        public long Amount { get; set; }

        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "ip_address")]
        public string IP_address { get; set; }

        [DataMember(Name = "created_at")]
        public DateTime Created { get; set; }

        [DataMember(Name = "error_message")]
        public string ErrorMessage { get; set; }

        [DataMember(Name = "status_message")]
        public string Status { get; set; }

        [DataMember(Name = "card_token")]
        public string Card_Token { get; set; }

        [DataMember(Name = "customer_token")]
        public string Customer_Token { get; set; }

        [DataMember(Name = "card")]
        public Card Card { get; set; }

    }
}
