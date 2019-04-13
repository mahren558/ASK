using System;
using System.Runtime.Serialization;


namespace ASKPayroll
{
    public class Geography
    {
        [DataMember]
        public int GeographyKey { get; set; }   
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember]
        public string PostalCode { get; set; }
        [DataMember]
        public string County { get; set; }
        [DataMember]
        public string Country { get; set; }
    }
}
