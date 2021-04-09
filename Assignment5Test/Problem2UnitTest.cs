using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem2;
using System;

/** Statement of Authorship
 *I, Michael Helbert, student number 000788384, certify that all code submitted is my own work; that I have not copied it from any other source.
 *I also certify that I have not allowed my work to be copied by others.
*/

namespace Assignment5Test
{
    [TestClass]
    public class Problem2UnitTest
    {
        /// <summary>
        /// Tests the low end computer builder
        /// </summary>
        [TestMethod]
        public void TestLowEndBuilderConstruction()
        {
            //Initialize the builder
            var lowEndBuilder = new LowEndComputerBuilder();

            //Tell the director to construct the builder
            //No exceptions should occure while building the computer since the components are hardcoded by the developer
            ComputerDirector.Construct(lowEndBuilder);

            //Check each component of the Computer object to ensure that no components are missing and were successfully initialized
            Assert.IsNotNull(lowEndBuilder.Computer.Motherboard);
            Assert.IsNotNull(lowEndBuilder.Computer.HardDrive);
            Assert.IsNotNull(lowEndBuilder.Computer.Case);
        }

        /// <summary>
        /// Tests the medium end computer builder
        /// </summary>
        [TestMethod]
        public void TestMediumEndBuilderConstruction()
        {
            //Initialize the builder
            var mediumEndBuilder = new MediumEndComputerBuilder();

            //Tell the director to construct the builder
            //No exceptions should occure while building the computer since the components are hardcoded by the developer
            ComputerDirector.Construct(mediumEndBuilder);

            //Check each component of the Computer object to ensure that no components are missing and were successfully initialized
            Assert.IsNotNull(mediumEndBuilder.Computer.Motherboard);
            Assert.IsNotNull(mediumEndBuilder.Computer.HardDrive);
            Assert.IsNotNull(mediumEndBuilder.Computer.Case);
        }

        /// <summary>
        /// Tests the high end computer builder
        /// </summary>
        [TestMethod]
        public void TestHighEndBuilderConstruction()
        {
            //Initialize the builder
            var highEndBuilder = new HighEndComputerBuilder();

            //Tell the director to construct the builder
            //No exceptions should occure while building the computer since the components are hardcoded by the developer
            ComputerDirector.Construct(highEndBuilder);

            //Check each component of the Computer object to ensure that no components are missing and were successfully initialized
            Assert.IsNotNull(highEndBuilder.Computer.Motherboard);
            Assert.IsNotNull(highEndBuilder.Computer.HardDrive);
            Assert.IsNotNull(highEndBuilder.Computer.Case);
        }

        /// <summary>
        /// Tests the manual construction of a computer
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestManualComputerCreation()
        {
            CPU cpu = new CPU(
                speed: 2.8,
                manufacturer: Manufacturer.Intel,
                socketType: "LGA 1150",
                cacheSize: 2048,
                cores: 2
            );

            Memory[] memory = new Memory[2]
            {
                new Memory(
                    readSpeed: 1024,
                    writeSpeed: 1024,
                    type: MemoryType.DDR2,
                    size: 1024
                ),
                new Memory(
                    readSpeed: 1024,
                    writeSpeed: 1024,
                    type: MemoryType.DDR2,
                    size: 1024
                )
            };

            GraphicsCard graphicsCard = new GraphicsCard(
                speed: 1024,
                videoMemory: 1024,
                cudaCores: 800,
                fans: 1
            );

            Case @case = new Case(
                length: 50.4,
                width: 20.2,
                height: 30.1,
                fans: 1,
                vents: 1
            );

            HardDrive hardDrive = new HardDrive(
                capacity: 500,
                HardDriveType.HDD,
                readSpeed: 1024,
                writeSpeed: 920
            );

            //Raise the ArgumentOutOfRangeException because the amount of memory cards exceeds the "memorySlots" argument.
            Motherboard motherboardException = new Motherboard(
                memorySlots: 1,
                powerConsumption: 700,
                pciSlots: 4,
                formFactor: new FormFactor(
                    name: "ATX",
                    new DateTime(1999, 06, 04),
                    width: 20,
                    depth: 30,
                    usbSlots: 6
                ),
                hardDriveLimit: 2,
                cpu: cpu,
                memory: memory,
                graphicsCard: graphicsCard
            );

            //Proper motherboard which should not raise any exceptions
            Motherboard motherboard = new Motherboard(
                memorySlots: 2,
                powerConsumption: 700,
                pciSlots: 4,
                formFactor: new FormFactor(
                    name: "ATX",
                    new DateTime(1999, 06, 04),
                    width: 20,
                    depth: 30,
                    usbSlots: 6
                ),
                hardDriveLimit: 2,
                cpu: cpu,
                memory: memory,
                graphicsCard: graphicsCard
            );

            Computer computer = new Computer(motherboard, hardDrive, @case);

            //Check each component of the Computer object to ensure that no components are missing and were successfully initialized
            Assert.IsNotNull(computer.Motherboard);
            Assert.IsNotNull(computer.HardDrive);
            Assert.IsNotNull(computer.Case);

            //Check the computer's clock speed to what we set it above for assurance that other properties were correctly assigned
            Assert.AreEqual(cpu.Speed, computer.Motherboard.CPU.Speed);
        }
    }
}
