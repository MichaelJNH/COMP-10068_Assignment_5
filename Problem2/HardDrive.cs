using System;
using System.Collections.Generic;
using System.Text;

/** Statement of Authorship
 *I, Michael Helbert, student number 000788384, certify that all code submitted is my own work; that I have not copied it from any other source.
 *I also certify that I have not allowed my work to be copied by others.
*/

namespace Problem2
{
    public enum HardDriveType
    {
        SSD,
        HDD
    }

    /// <summary>
    /// A class which represents a HardDrive component of type SSD or HDD
    /// </summary>
    public class HardDrive
    {
        public int Capacity { get; private set; } //Size in GB
        public HardDriveType Type { get; private set; } //SSD or HDD
        public int ReadSpeed { get; private set; } //Speed in MB
        public int WriteSpeed { get; private set; } //Speed in MB

        /// <summary>
        /// Initializes a new HardDrive
        /// </summary>
        /// <param name="capacity">Size in GB</param>
        /// <param name="type">The type of the HardDrive, either SSD to HDD</param>
        /// <param name="readSpeed">The read speed</param>
        /// <param name="writeSpeed">The write speed</param>
        public HardDrive(int capacity, HardDriveType type, int readSpeed, int writeSpeed)
        {
            if (capacity < 0) throw new ArgumentOutOfRangeException("Capacity must be a positive value");
            if (readSpeed < 0) throw new ArgumentOutOfRangeException("Read Speed must be a positive value");
            if (writeSpeed < 0) throw new ArgumentOutOfRangeException("Write Speed must be a positive value");

            Capacity = capacity;
            Type = type;
            ReadSpeed = readSpeed;
            WriteSpeed = writeSpeed;
        }
    }
}
