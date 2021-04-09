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
    /// Represents the definition on how to build a computer
    /// </summary>
    public interface IComputerBuilder
    {
        public void BuildMotherboard();
        public void BuildCase();
        public void BuildHardDrive();
    }
}
