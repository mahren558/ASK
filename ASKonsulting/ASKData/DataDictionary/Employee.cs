using System;
using System.Runtime.Serialization;

namespace ASKPayroll
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int EmployeeId { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string MiddleIntiial { get; set; }
        [DataMember]
        public string Addess1 { get; set; }
        [DataMember]
        public string Address2 { get; set; }
        [DataMember]
        public int GeographyKey { get; set; }
        [DataMember]
        public string HomePhone { get; set; }
        [DataMember]
        public string MobilePhone { get; set; }
        [DataMember]
        public string BusEmail { get; set; }
        [DataMember]
        public string PersEmail { get; set; }
        [DataMember]
        public int EmployeeType { get; set; }
        [DataMember]
        public string SSN { get; set; }
        [DataMember]
        public decimal HourlyRate { get; set; }
        [DataMember]
        public decimal AnnualSalary { get; set; }
        [DataMember]
        public decimal WeeklySalary { get; set; }
        [DataMember]
        public int EmployeeStatus { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public DateTime EndDate { get; set; }
    }

    [DataContract]
    public class EmployeeList
    {
        [DataMember]
        public int EmployeeId { get; set; }
        [DataMember]
        public string Name { get; set; }
    }

}
