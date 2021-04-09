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
    /// Represents a class that builds a "low-end" computer.
    /// </summary>
    public class LowEndComputerBuilder : IComputerBuilder
    {
        public Computer Computer { get; private set; }

        public LowEndComputerBuilder()
        {
            Computer = new Computer();
        }

        /// <summary>
        /// Creates a small case with 1 fan and 1 vent
        /// </summary>
        public void BuildCase()
        {
            Computer.Case = new Case(
                length: 41.6,
                width: 24,
                height: 46.5,
                fans: 1,
                vents: 1
            );
        }

        /// <summary>
        /// Creates an hdd with low capacity and slow rw speed
        /// </summary>
        public void BuildHardDrive()
        {
            Computer.HardDrive = new HardDrive(
                capacity: 500,
                type: HardDriveType.HDD,
                readSpeed: 220,
                writeSpeed: 220
            );
        }

        /// <summary>
        /// Creates an old motherboard with a slow cpu and little memory.
        /// Graphics card is slow.
        /// </summary>
        public void BuildMotherboard()
        {
            FormFactor formFactor = new FormFactor(
                name: "ATX",
                date: new DateTime(2001, 01, 01),
                width: 12,
                depth: 9.6,
                usbSlots: 8
            );

            CPU cpu = new CPU(
                speed: 2.8,
                Manufacturer.AMD,
                socketType: "S1",
                cacheSize: 2048,
                cores: 4
            );

            Memory[] memory = new Memory[2]
            {
                new Memory(
                    readSpeed: 800,
                    writeSpeed: 800,
                    type: MemoryType.DDR3,
                    size: 1024
                ),
                new Memory(
                    readSpeed: 800,
                    writeSpeed: 800,
                    type: MemoryType.DDR3,
                    size: 1024
                )
            };

            GraphicsCard graphicsCard = new GraphicsCard(
                speed: 800,
                videoMemory: 2048,
                cudaCores: 1200,
                fans: 1
            );

            Computer.Motherboard = new Motherboard(
                memorySlots: 4,
                powerConsumption: 500,
                pciSlots: 3,
                formFactor: formFactor,
                hardDriveLimit: 2,
                cpu: cpu,
                memory: memory,
                graphicsCard: graphicsCard
            );
        }
    }
}
