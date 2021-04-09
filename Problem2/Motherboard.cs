using System;
using System.Collections.Generic;
using System.Text;

/** Statement of Authorship
 *I, Michael Helbert, student number 000788384, certify that all code submitted is my own work; that I have not copied it from any other source.
 *I also certify that I have not allowed my work to be copied by others.
*/

namespace Problem2
{
    /// <summary>
    /// A class that represents the Motherboard component of a computer.
    /// Most computer components are attached to this component.
    /// </summary>
    public class Motherboard
    {
        public int MemorySlots { get; private set; } //Amount of memory slots
        public int PowerConsumption { get; private set; } //Power consumption in Watts
        public int PCISlots { get; private set; } //Amount of PCI slots
        public FormFactor FormFactor { get; private set; } //The form factor of the motherboard
        public int HardDriveLimit { get; private set; } //The amount of harddrives this motherboard can support
        public CPU CPU { get; private set; } //The CPU attached to this motherboard
        public Memory[] Memory { get; private set; } //All of the memory attached to this motherboard
        public GraphicsCard GraphicsCard { get; private set; } //The graphics card attached to this motherboard

        /// <summary>
        /// Initializes the motherboard
        /// </summary>
        /// <param name="memorySlots">The amount of memory slots</param>
        /// <param name="powerConsumption">The power consumption in Watts that the motherboard needs to consume</param>
        /// <param name="pciSlots">The amount of PCI slots</param>
        /// <param name="formFactor">The form factor of this motherboard</param>
        /// <param name="hardDriveLimit">The limit of harddrives this motherboard has</param>
        /// <param name="cpu">The CPU</param>
        /// <param name="memory">All of the memory attached to this motherboard, cannot exceed the `memorySlots` value</param>
        /// <param name="graphicsCard">The graphics card</param>
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
