using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PinPayments.Models
{
    [DataContract]
    public class Message
    {
        [DataMember(Name = "code")]
        public string code { get; set; }
        [DataMember(Name = "message")]
        public string message { get; set; }
        [DataMember(Name = "param")]
        public string param { get; set; }
    }
}
