using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using PinPayments.Models;
using PinPayments.Actions;

namespace PinPayments.Models
{
     
    public class RefundResponse : PinRefundError
    {
        [JsonProperty("response")]
        public Refund Refund { get; set; }
        public Pagination Pagination { get; set; }
        public int Count { get; set; }
    }

    public class RefundsResponse : PinError
    {
        [JsonProperty("response")]
        public Refund[] Refunds { get; set; }
        public Pagination Pagination { get; set; }
        public int Count { get; set; }
    }

    public class Refund
    {
        [JsonProperty("token")]
        public string Token{get;set;}

        [JsonProperty("success")]
        public bool? Success { get; set; }
        
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("charge")]
        public string Charge { get; set; }
        
        [JsonProperty("created_at")]
        public DateTime Created { get; set; }

        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }

        [JsonProperty("status_message")]
        public string Status{ get; set; }
    }
}
