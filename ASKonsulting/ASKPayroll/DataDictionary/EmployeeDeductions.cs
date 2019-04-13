using System;
using System.Runtime.Serialization;

namespace ASKPayroll
{


    [DataContract]
    public class EmployeeDeductions
    {
        [DataMember]
        public int EmployeeDeductionTypeId { get; set; }

        [DataMember]
        public string EmployeeDeductionTypeName { get; set; }

        [DataMember]
        public int PreTax { get; set; }

    }
}
