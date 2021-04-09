using System;
using System.Collections.Generic;
using System.Text;

/** Statement of Authorship
 *I, Michael Helbert, student number 000788384, certify that all code submitted is my own work; that I have not copied it from any other source.
 *I also certify that I have not allowed my work to be copied by others.
*/

namespace Problem2
{
    public enum MemoryType
    {
        DDR1,
        DDR2,
        DDR3,
        DDR4
    }

    /// <summary>
    /// A class which repressents the memory components of a computer
    /// </summary>
    public class Memory
    {
        public int ReadSpeed { get; private set; } //Speed in MHz
        public int WriteSpeed { get; private set; } //Speed in MHz
        public MemoryType Type { get; private set; } //DDR1 through 4
        public int Size { get; private set; } //Size in GB

        /// <summary>
        /// Initializes a new Memory component
        /// </summary>
        /// <param name="readSpeed">The read speed in MHz</param>
        /// <param name="writeSpeed">The write speed in MHz</param>
        /// <param name="type">The memory type, either DDR1 to 4</param>
        /// <param name="size">The amount of memory in GB</param>
        public Memory(int readSpeed, int writeSpeed, MemoryType type, int size)
        {
            if (readSpeed < 0) throw new ArgumentOutOfRangeException("Read Speed must be a positive value");
            if (writeSpeed < 0) throw new ArgumentOutOfRangeException("Write Speed must be a positive value");
            if (size < 0) throw new ArgumentOutOfRangeException("Size must be a positive value");

            ReadSpeed = readSpeed;
            WriteSpeed = writeSpeed;
            Type = type;
            Size = size;
        }
    }
}
