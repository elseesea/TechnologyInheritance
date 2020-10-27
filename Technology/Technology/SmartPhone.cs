using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public string Carrier { get; set; }
        private bool serviceActivated;
        public readonly string SerialNumber = "3873884388349089";
        public SmartPhone(string processor, int memory, int storage, string carrier, bool serviceActivated = false) : base(processor, memory, storage)
        {
            Carrier = carrier;
            this.serviceActivated = serviceActivated;
        }

        public void ActivateService()
        {
            serviceActivated = true;
        }

        public void DeactivateService()
        {
            serviceActivated = false;
        }

        public bool GetServiceStatus()
        {
            return serviceActivated;
        }
    }
}
