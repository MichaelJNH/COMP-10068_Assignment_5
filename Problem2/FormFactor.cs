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
    /// A class which represents the form-factor of a Motherboard
    /// Only has basic detail
    /// </summary>
    public class FormFactor
    {
        public string Name { get; private set; } //The name of the form factor
        public DateTime Date { get; private set; } //The date the form factor was developed
        public double Width { get; private set; } //In CM
        public double Depth { get; private set; } //In CM
        public int USBSlots { get; private set; } //Amount of USB slots

        /// <summary>
        /// Initializes a new FormFactor
        /// </summary>
        /// <param name="name">The name of the form factor</param>
        /// <param name="date">The date the form factor was developed</param>
        /// <param name="width">Width of the form factor in CM</param>
        /// <param name="depth">Depth of the form factor in CM</param>
        /// <param name="usbSlots">Amount of USB slots</param>
        public FormFactor(string name, DateTime date, double width, double depth, int usbSlots = 0)
        {
            if (date.Year < 1983) throw new ArgumentException("FormFactor date cannot be earlier than 1983");
            else if (date > DateTime.Now) throw new ArgumentException("FormFactor date cannot be in the future");
            if (width < 1) throw new ArgumentOutOfRangeException("Width must be greater than 0");
            if (depth < 1) throw new ArgumentOutOfRangeException("Depth must be greater than 0");
            if (usbSlots < 0) throw new ArgumentOutOfRangeException("USB Slots must be a positive value");

            Name = name;
            Date = date;
            Width = width;
            Depth = depth;
            USBSlots = usbSlots;
        }
    }
}
