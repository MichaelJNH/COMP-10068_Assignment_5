using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public enum Manufacturer
    {
        Intel,
        AMD
    }

    public class CPU
    {        

        public double Speed { get; private set; } //GHz
        public Manufacturer Manufacturer { get; private set; }
        public string SocketType { get; private set; }
        public int CacheSize { get; private set; } //KB
        public int Cores { get; private set; }

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
