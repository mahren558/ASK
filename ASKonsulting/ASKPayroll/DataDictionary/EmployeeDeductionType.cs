using System;
using System.Runtime.Serialization;

namespace ASKPayroll
{


    [DataContract]
    public class EmployeeDeductions
    {
        [DataMember]
        public int EmployeeId { get; set; }

        [DataMember]
        public int DeductionType { get; set; }

        [DataMember]
        public DateTime DateEntered { get; set; }

        [DataMember]
        public DateTime DateChanged { get; set; }

        [DataMember]
        public bool PctOfSalary { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

    }
}
