using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using PinPayments.Actions;

namespace PinPayments.Models
{
    [DataContract]
    public class Customers
    {
        [DataMember(Name = "response")]
        public List<Customer> Customer { get; set; }
        [DataMember(Name = "pagination")]
        public Pagination Pagination { get; set; }
        [DataMember(Name = "count")]
        public int Count { get; set; }
    }
    [DataContract]
    public class CustomerAdd:PinError
    {
        [DataMember(Name = "response")]
        public Customer Response { get; set; }
    }
    [DataContract]
    public class Customer
    {
        public Customer()
        {
            _card = new Card();
        }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "token")]
        public string Token { get; set; }

        [DataMember(Name = "created_at")]
        public DateTime? DateCreated { get; set; }

        private Card _card;

        [IgnoreDataMemberName]
        [DataMember(Name = "card")]
        public Card Card
        {
            get { return _card; }
            set
            {
                if (value == null)
                {
                    _card = new Card();
                }
                else
                {
                    _card = value;
                }

            }
        }

        [DataMember(Name = "card[number]")]
        public string CardNumber { get { return Card.CardNumber; } set { Card.CardNumber = value; } }

        [IgnoreDataMember]
        public string DisplayNumber { get { return Card.DisplayNumber; }  }

        [DataMember(Name = "card[expiry_month]")]
        public string ExpiryMonth { get { return Card.ExpiryMonth; } set { Card.ExpiryMonth = value; } }

        [DataMember(Name = "card[expiry_year]")]
        public string ExpiryYear { get { return Card.ExpiryYear; } set { Card.ExpiryYear = value; } }

        [DataMember(Name = "card[cvc]")]
        public string CVC { get { return Card.CVC; } set { Card.CVC = value; } }

        [DataMember(Name = "card[name]")]
        public string Name { get { return Card.Name; } set { Card.Name = value; } }

        [DataMember(Name = "card[address_line1]")]
        public string Address1 { get { return Card.Address1; } set { Card.Address1 = value; } }

        [DataMember(Name = "card[address_line2]")]
        public string Address2 { get { return Card.Address2; } set { Card.Address2 = value; } }

        [DataMember(Name = "card[address_city]")]
        public string City { get { return Card.City; } set { Card.City = value; } }

        [DataMember(Name = "card[address_postcode]")]
        public string Postcode { get { return Card.Postcode; } set { Card.Postcode = value; } }

        [DataMember(Name = "card[address_state]")]
        public string State { get { return Card.State; } set { Card.State = value; } }

        [DataMember(Name = "card[address_country]")]
        public string Country { get { return Card.Country; } set { Card.Country = value; } }
    }
    [DataContract]
    public class CustomerUpdate:Response
    {
        [DataMember(Name = "response")]
        public Customer Customer { get; set; }
    }
}
