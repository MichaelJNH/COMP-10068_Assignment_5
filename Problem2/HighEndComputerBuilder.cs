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
    /// Represents a class that builds a "high-end" computer.
    /// </summary>
    public class HighEndComputerBuilder : IComputerBuilder
    {
        public Computer Computer { get; private set; }

        public HighEndComputerBuilder()
        {
            Computer = new Computer();
        }

        /// <summary>
        /// Creates a medium case with 4 fans and 3 vents
        /// </summary>
        public void BuildCase()
        {
            Computer.Case = new Case(
                length: 52,
                width: 28.4,
                height: 58,
                fans: 4,
                vents: 3
            );
        }

        /// <summary>
        /// Creates an ssd with high capacity and verry fast rw speed
        /// </summary>
        public void BuildHardDrive()
        {
            Computer.HardDrive = new HardDrive(
                capacity: 2048,
                type: HardDriveType.SSD,
                readSpeed: 800,
                writeSpeed: 800
            );
        }

        /// <summary>
        /// Creates an new motherboard with a very good cpu and high amount of memory.
        /// Graphics card is very fast.
        /// </summary>
        public void BuildMotherboard()
        {
            FormFactor formFactor = new FormFactor(
                name: "ATX",
                date: new DateTime(2021, 01, 01),
                width: 12,
                depth: 9.6,
                usbSlots: 8
            );

            CPU cpu = new CPU(
                speed: 4.8,
                Manufacturer.Intel,
                socketType: "LGA 1151",
                cacheSize: 4096,
                cores: 12
            );

            Memory[] memory = new Memory[4]
            {
                new Memory(
                    readSpeed: 4096,
                    writeSpeed: 4096,
                    type: MemoryType.DDR4,
                    size: 4096
                ),
                new Memory(
                    readSpeed: 4096,
                    writeSpeed: 4096,
                    type: MemoryType.DDR4,
                    size: 4096
                ),
                new Memory(
                    readSpeed: 4096,
                    writeSpeed: 4096,
                    type: MemoryType.DDR4,
                    size: 4096
                ),
                new Memory(
                    readSpeed: 4096,
                    writeSpeed: 4096,
                    type: MemoryType.DDR4,
                    size: 4096
                )
            };

            GraphicsCard graphicsCard = new GraphicsCard(
                speed: 3200,
                videoMemory: 8192,
                cudaCores: 3000,
                fans: 3
            );

            Computer.Motherboard = new Motherboard(
                memorySlots: 6,
                powerConsumption: 850,
                pciSlots: 4,
                formFactor: formFactor,
                hardDriveLimit: 6,
                cpu: cpu,
                memory: memory,
                graphicsCard: graphicsCard
            );
        }
    }
}
