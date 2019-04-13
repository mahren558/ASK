using System;
using System.Runtime.Serialization;

namespace ASKPayroll
{
    public class PayPeriods
    {
        [DataMember]
        public int PayPeriodId { get; set; }
        [DataMember]
        public int Year { get; set; }
        [DataMember]
        public int Period { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public DateTime EndDate { get; set; }
    }
}
