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
    /// A class that automates the construction of a computer
    /// </summary>
    public static class ComputerDirector
    {
        /// <summary>
        /// Builds a computer based on a ComputerBuilder
        /// </summary>
        /// <param name="builder">The type of ComputerBuilder to build this computer off of</param>
        public static void Construct(IComputerBuilder builder)
        {
            builder.BuildMotherboard();
            builder.BuildHardDrive();
            builder.BuildMotherboard();
        }
    }
}
