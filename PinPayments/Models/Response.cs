using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using PinPayments.Models;

namespace PinPayments.Models
{
    public class Response
    {
        public string Error { get; set; }
        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }
        [JsonProperty("charge_token")]
        public string ChargeToken { get; set; }
        public Message[] Messages { get; set; }
        
    }
}
