using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public static class ComputerDirector
    {
        public static void Construct(IComputerBuilder builder)
        {
            builder.BuildMotherboard();
            builder.BuildHardDrive();
            builder.BuildMotherboard();
        }
    }
}
