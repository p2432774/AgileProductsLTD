using System;

namespace Software_HardwareClasses
{
    public class clsHardware
    {
        public DateTime DateAdded { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int AmountInStock { get; set; }
        public bool StockRequired { get; set; }
    }
}