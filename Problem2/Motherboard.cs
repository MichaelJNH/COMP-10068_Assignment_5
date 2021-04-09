using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public class Motherboard
    {
        public int MemorySlots { get; private set; }
        public int PowerConsumption { get; private set; } //Watts
        public int PCISlots { get; private set; }
        public FormFactor FormFactor { get; private set; }
        public int HardDriveLimit { get; private set; }
        public CPU CPU { get; private set; }
        public Memory[] Memory { get; private set; }
        public GraphicsCard GraphicsCard { get; private set; }

        public Motherboard(int memorySlots, int powerConsumption, int pciSlots, FormFactor formFactor, int hardDriveLimit, CPU cpu, Memory[] memory, GraphicsCard graphicsCard)
        {
            if (memorySlots < memory.Length) throw new ArgumentOutOfRangeException("Amount of memory cards exceed amount of available memory slots");
            if (powerConsumption < 0) throw new ArgumentOutOfRangeException("Power Consumption must be a positive value");
            if (pciSlots < 0) throw new ArgumentOutOfRangeException("PCI Slots must be a positive value");
            if (hardDriveLimit < 1) throw new ArgumentOutOfRangeException("HardDrive limit must be greater than 0");

            MemorySlots = memorySlots;
            PowerConsumption = powerConsumption;
            PCISlots = pciSlots;
            FormFactor = formFactor;
            HardDriveLimit = hardDriveLimit;
            CPU = cpu;
            Memory = memory;
            GraphicsCard = graphicsCard;
        }
    }
}
