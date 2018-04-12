using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PinPayments.Actions
{
    public class ChargeSearch
    {
        
        [DataMember(Name = "query")]
        public string Query{get;set;}
        
        [DataMember(Name = "startDate")]
        public DateTime? StartDate{get;set;}
        
        [DataMember(Name = "endDate")]
        public DateTime? EndDate{get;set;}

        [IgnoreDataMember]
        public ChargeSearchSortEnum Sort {get;set;}

        [DataMember(Name = "sort")]
        private string sort
        {
            get
            {
                switch (Sort)
                {
                    case ChargeSearchSortEnum.Amount:
                        return "amount";
                    case ChargeSearchSortEnum.Description:
                        return "description";
                    case ChargeSearchSortEnum.Created:
                    default:
                        return "created_at";
                }

            }
        }

        [IgnoreDataMember]
        public SortDirectionEnum SortDirection { get; set; }

        [DataMember(Name = "direction")]
        private int direction
        {
            get
            {
                if (SortDirection == SortDirectionEnum.Ascending)
                {
                    return 1;
                }
                return -1;
            }
        }
    }

    public enum ChargeSearchSortEnum
    {
        Created, Description, Amount
    }

    public enum SortDirectionEnum
    {
        Ascending = 1, Descending =-1
    }
}
