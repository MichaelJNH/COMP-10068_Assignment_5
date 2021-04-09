using System;
using System.Collections.Generic;
using System.Text;

/** Statement of Authorship
 *I, Michael Helbert, student number 000788384, certify that all code submitted is my own work; that I have not copied it from any other source.
 *I also certify that I have not allowed my work to be copied by others.
*/

namespace Problem2
{
    public enum Manufacturer
    {
        Intel,
        AMD
    }

    /// <summary>
    /// A class that represents a CPU component
    /// </summary>
    public class CPU
    {        

        public double Speed { get; private set; } //Clock speed in GHz
        public Manufacturer Manufacturer { get; private set; } //Intel or AMD
        public string SocketType { get; private set; }
        public int CacheSize { get; private set; } //Cache Size in KB
        public int Cores { get; private set; } //Number of cores

        /// <summary>
        /// Initializes the CPU
        /// </summary>
        /// <param name="speed">The clock speed</param>
        /// <param name="manufacturer">Which manufacturer made this CPU (Intel, AMD)</param>
        /// <param name="socketType">The socket type</param>
        /// <param name="cacheSize">The cache size</param>
        /// <param name="cores">Amount of cores</param>
        public CPU(double speed, Manufacturer manufacturer, string socketType, int cacheSize, int cores)
        {
            if (speed < 0) throw new ArgumentOutOfRangeException("Speed must be a positive value");
            if (cacheSize < 0) throw new ArgumentOutOfRangeException("CacheSize must be a positive value");
            if (cores < 0) throw new ArgumentOutOfRangeException("Cores must be a positive value");
            if (string.IsNullOrEmpty(socketType)) throw new ArgumentException("Invalid SocketType");

            Speed = speed;
            Manufacturer = manufacturer;
            SocketType = socketType;
            CacheSize = cacheSize;
            Cores = cores;
        }
    }
}
