using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public enum MemoryType
    {
        DDR1,
        DDR2,
        DDR3,
        DDR4
    }

    public class Memory
    {
        public int ReadSpeed { get; private set; } //MHz
        public int WriteSpeed { get; private set; } //MHz
        public MemoryType Type { get; private set; }
        public int Size { get; private set; } //In GB

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
