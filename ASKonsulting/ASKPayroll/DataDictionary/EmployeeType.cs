using System;
using System.Runtime.Serialization;

namespace ASKPayroll
{
    [DataContract]
    public class EmployeeType
    {
        [DataMember]
        public int EmployeeTypeId { get; set; }

        [DataMember]
        public string EmployeeTypeName { get; set; }
    }
}
