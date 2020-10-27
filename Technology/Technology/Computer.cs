using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Technology
{

    public class Computer : AbstractEntity
    {
        // For a parent class: add 3 fields, 2 methods, and a constructor.
        public string Processor { get; set; }
        public int Memory { get; set; }
        public int Storage { get; set; }
        private int objectId;

        public Computer (string processor, int memory, int storage)
        {
            Processor = processor;
            Memory = memory; // in MBs (megabytes)
            Storage = storage; // in GBs (gigabytes)
            this.objectId = GetObjectId();
        }

        public void UpgradeMemory(int memory)
        {
            Memory += memory;
        }

        public void UpgradeStorage (int storage)
        {
            Storage += storage;
        }

        public override int GetObjectId()
        {
            AbstractEntity.objectIDnumber += 1;
            return AbstractEntity.objectIDnumber;
        }

    }
}
