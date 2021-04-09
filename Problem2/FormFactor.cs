using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public class FormFactor
    {
        public string Name { get; private set; }
        public DateTime Date { get; private set; }
        public double Width { get; private set; }
        public double Depth { get; private set; }
        public int USBSlots { get; private set; }

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
