using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PinPayments.Models;
using PinPayments.Actions;
using System.Runtime.Serialization;

namespace PinPayments
{
    [DataContract]
    public class RefundResponse : PinRefundError
    {
        [DataMember(Name = "response")]
        public Refund Response { get; set; }
        [DataMember(Name = "pagination")]
        public Pagination Pagination { get; set; }
    }

    [DataContract]
    public class RefundsResponse : PinError
    {
        [DataMember(Name = "response")]
        public Refund[] Response { get; set; }
        [DataMember(Name = "pagination")]
        public Pagination Pagination { get; set; }
    }

    [DataContract]
    public class Refund
    {
        [DataMember(Name = "token")]
        public string Token{get;set;}

        [DataMember(Name = "success")]
        public bool? Success { get; set; }
        
        [DataMember(Name = "amount")]
        public long Amount { get; set; }

        [DataMember(Name = "currency")]
        public string Currency { get; set; }

        [DataMember(Name = "charge")]
        public string Charge { get; set; }
        
        [DataMember(Name = "created_at")]
        public DateTime Created { get; set; }

        [DataMember(Name = "error_message")]
        public string ErrorMessage { get; set; }

        [DataMember(Name = "status_message")]
        public string Status{ get; set; }
    }
}
