using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public enum HardDriveType
    {
        SSD,
        HDD
    }

    public class HardDrive
    {
        public int Capacity { get; private set; } //GB
        public HardDriveType Type { get; private set; }
        public int ReadSpeed { get; private set; } //MB
        public int WriteSpeed { get; private set; } //MB

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
