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
    /// Represents a class that builds a "medium-end" computer.
    /// </summary>
    class MediumEndComputerBuilder : IComputerBuilder
    {
        public Computer Computer { get; private set; }

        public MediumEndComputerBuilder()
        {
            Computer = new Computer();
        }

        /// <summary>
        /// Creates a medium case with 2 fans and 2 vents
        /// </summary>
        public void BuildCase()
        {
            Computer.Case = new Case(
                length: 52,
                width: 28.4,
                height: 58,
                fans: 2,
                vents: 2
            );
        }

        /// <summary>
        /// Creates an ssd with medium capacity and fast rw speed
        /// </summary>
        public void BuildHardDrive()
        {
            Computer.HardDrive = new HardDrive(
                capacity: 1024,
                type: HardDriveType.SSD,
                readSpeed: 500,
                writeSpeed: 500
            );
        }

        /// <summary>
        /// Creates an semi-new motherboard with a good cpu and average amount of memory.
        /// Graphics card is medium-speed.
        /// </summary>
        public void BuildMotherboard()
        {
            FormFactor formFactor = new FormFactor(
                name: "ATX",
                date: new DateTime(2015, 01, 01),
                width: 12,
                depth: 9.6,
                usbSlots: 8
            );

            CPU cpu = new CPU(
                speed: 3.6,
                Manufacturer.AMD,
                socketType: "AM4",
                cacheSize: 4096,
                cores: 6
            );

            Memory[] memory = new Memory[4]
            {
                new Memory(
                    readSpeed: 2000,
                    writeSpeed: 2000,
                    type: MemoryType.DDR4,
                    size: 2048
                ),
                new Memory(
                    readSpeed: 2000,
                    writeSpeed: 2000,
                    type: MemoryType.DDR4,
                    size: 2048
                ),
                new Memory(
                    readSpeed: 2000,
                    writeSpeed: 2000,
                    type: MemoryType.DDR4,
                    size: 2048
                ),
                new Memory(
                    readSpeed: 2000,
                    writeSpeed: 2000,
                    type: MemoryType.DDR4,
                    size: 2048
                )
            };

            GraphicsCard graphicsCard = new GraphicsCard(
                speed: 1500,
                videoMemory: 4096,
                cudaCores: 2000,
                fans: 2
            );

            Computer.Motherboard = new Motherboard(
                memorySlots: 4,
                powerConsumption: 700,
                pciSlots: 4,
                formFactor: formFactor,
                hardDriveLimit: 4,
                cpu: cpu,
                memory: memory,
                graphicsCard: graphicsCard
            );
        }
    }
}
