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
    /// A class that represents a computer case with dimensions, fans, and vents.
    /// </summary>
    public class Case
    {
        public double Length { get; private set; } //In Centimeters
        public double Width { get; private set; } //In Centimeters
        public double Height { get; private set; } //In Centimeters
        public int Fans { get; private set; }
        public int Vents { get; private set; }

        /// <summary>
        /// Initializes a new case
        /// </summary>
        /// <param name="length">Length in CM</param>
        /// <param name="width">Width in CM</param>
        /// <param name="height">Height in CM</param>
        /// <param name="fans">Amount of fans</param>
        /// <param name="vents">Amount of vents</param>
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
