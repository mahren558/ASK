using System;
using System.Runtime.Serialization;

namespace ASKPayroll
{
    public class TimeLog
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int EmployeeId { get; set; }
        [DataMember]
        public int PayPeriodId { get; set; }
        [DataMember]
        public int Day { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public decimal Hours { get; set; }
        [DataMember]
        public string Note { get; set; }
    }
}
