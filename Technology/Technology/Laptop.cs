using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Laptop : Computer
    {
        // For a child class: add at least 1 additional field and 1 additional method.
        public double MonitorSize { get; set; }
        public readonly string Brand = "Dell";

        public Laptop(string processor, int memory, int storage, double monitorSize) : base(processor, memory, storage)
        {
            MonitorSize = monitorSize;
        }

        public string Reimage()
        {
            return "Laptop reimaged successfully";
        }

    }
}
