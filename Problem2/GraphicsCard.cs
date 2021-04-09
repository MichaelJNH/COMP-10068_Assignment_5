using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public class GraphicsCard
    {
        public int Fans { get; private set; }
        public int Speed { get; private set; } //MHz
        public int VideoMemory { get; private set; } //MB
        public int CUDACores { get; private set; }

        public GraphicsCard(int speed, int videoMemory, int cudaCores, int fans = 0)
        {
            if (fans < 0) throw new ArgumentOutOfRangeException("Fans must be a positive value");
            if (speed < 0) throw new ArgumentOutOfRangeException("Speed must be a positive value");
            if (cudaCores < 0) throw new ArgumentOutOfRangeException("Cuda Cores must be a positive value");
            if (videoMemory < 0) throw new ArgumentOutOfRangeException("Video Memory must be a positive value");

            Fans = fans;
            Speed = speed;
            VideoMemory = videoMemory;
            CUDACores = cudaCores;
        }
    }
}
