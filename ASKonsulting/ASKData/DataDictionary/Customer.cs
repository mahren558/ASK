using System;
using System.Runtime.Serialization;

namespace ASKPayroll
{
    [DataContract]
    public class Customer
    {
        int CustomerId { get; set; }
        string CustomerName { get; set; }
        string ContactName { get; set; }
        string ContactPhone1 { get; set; }
        string ContactPhone2 { get; set; }
        string ContactEmail { get; set; }
        CustomerTerms Terms { get; set; }
    }

    [DataContract]
    public class CustomerAging : Customer
    {
        decimal CreditLimit { get; set; }
        decimal TotalDue { get; set; }
        decimal TotalPastDue { get; set; }
        decimal CurrentDue { get; set; }
        decimal Days30 { get; set; }
        decimal Days60 { get; set; }
        decimal Days90 { get; set; }
        decimal Days120Plus { get; set; }
    }

    [DataContract]
    public class CustomerAddress 
    {
        int CustomerId {get;set;} 
        string Address1 { get; set; }
        string Address2 { get; set; }
        int GeographyKey { get; set; }
        CustomerAddressType AddressType { get; set; }
    }

    [DataContract]
    public class CustomerTerms
    {
        int TermsId { get; set; }
        int TermsDays { get; set; }
        int TermsDescription { get; set; }
    }


    public enum CustomerAddressType
    {
        BillTo = 1,
        ShipTo
    }


}
