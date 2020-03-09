using System;

namespace Software_HardwareClasses
{
    public class clsOrder
    {
        public bool Active { get; set; }
        public string ShippedVia { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderID { get; set; }
        public string ShippingVia { get; set; }
    }
}