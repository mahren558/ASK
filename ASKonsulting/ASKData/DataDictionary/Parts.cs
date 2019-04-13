using System;
using System.Runtime.Serialization;

namespace ASKPayroll
{
    [DataContract]
    public class Parts
    {
        public int ItemId { get; set; }
        public string Description { get; set; }
        public decimal Unit_Price { get; set; }
        public int MinUnits { get; set; }
        public bool Taxable { get; set; }
    }
}
