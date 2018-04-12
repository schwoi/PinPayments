using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PinPayments.Models
{
    [DataContract]
    public class PinError
    {
        [DataMember(Name = "error")]
        public string Error { get; set; }

        [DataMember(Name = "error_description")]
        public string Description { get; set; }

        [DataMember(Name = "charge_token")]
        public string Token { get; set; }

        [DataMember(Name = "messages")]
        public ErrorMessage[] Messages { get; set; }
    }
    [DataContract]
    public class PinRefundError
    {
        [DataMember(Name = "error")]
        public string Error { get; set; }

        [DataMember(Name = "error_description")]
        public string Description { get; set; }

        [DataMember(Name = "charge_token")]
        public string Token { get; set; }

        public ErrorMessage Messages { get; set; }
    }
    [DataContract]
    public class ErrorMessage
    {
        [DataMember(Name = "code")]
        public string Code { get; set; }

        [DataMember(Name = "message")]
        public string Message { get; set; }

        [DataMember(Name = "param")]
        public string Param { get; set; }

        [DataMember(Name = "charge")]
        public string[] Charge { get; set; }

    }
}
