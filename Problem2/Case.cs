using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public class Case
    {
        public double Length { get; private set; } //Centimeters
        public double Width { get; private set; } //Centimeters
        public double Height { get; private set; } //Centimeters
        public int Fans { get; private set; }
        public int Vents { get; private set; }

        public Case(double length, double width, double height, int fans = 0, int vents = 0)
        {
            if (length < 1) throw new ArgumentOutOfRangeException("Length must be a greater than 0");
            if (width < 1) throw new ArgumentOutOfRangeException("Width must be a greater than 0");
            if (height < 1) throw new ArgumentOutOfRangeException("Height must be a greater than 0");
            if (fans < 0) throw new ArgumentOutOfRangeException("Fans must be a positive value");
            if (vents < 0) throw new ArgumentOutOfRangeException("Vents must be a positive value");

            Length = length;
            Width = width;
            Height = height;
            Fans =  fans;
            Vents = vents;
        }
    }
}
