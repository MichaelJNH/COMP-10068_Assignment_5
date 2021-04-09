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
    /// A class which represents a Graphics Card component
    /// </summary>
    public class GraphicsCard
    {
        public int Fans { get; private set; } //Amount of fans
        public int Speed { get; private set; } //Speed in MHz
        public int VideoMemory { get; private set; } //Amount of memory in MB
        public int CUDACores { get; private set; } //Amount of CUDACores

        /// <summary>
        /// Initializes a new Graphics Card
        /// </summary>
        /// <param name="speed">Speed in MHz</param>
        /// <param name="videoMemory">Amount of memory in MB</param>
        /// <param name="cudaCores">Amount of CUDACores</param>
        /// <param name="fans">Number of fans</param>
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
