using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using PinPayments.Models;

namespace PinPayments
{
    [DataContract]
    public class Response
    {
        [DataMember(Name = "error")]
        public string Error { get; set; }
        [DataMember(Name = "error_description")]
        public string ErrorDescription { get; set; }
        [DataMember(Name = "charge_token")]
        public string ChargeToken { get; set; }
        [DataMember(Name = "messages")]
        public Message[] Messages { get; set; }
    }
}
