using System;
using System.Runtime.Serialization;

namespace ASKPayroll
{
    [DataContract]
    public class EmployeeStatus
    {

        [DataMember]
        public int StatusId { get; set; }

        [DataMember]
        public string Status { get; set; }

    }
}
