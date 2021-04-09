using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public interface IComputerBuilder
    {
        public void BuildMotherboard();
        public void BuildCase();
        public void BuildHardDrive();
    }
}
