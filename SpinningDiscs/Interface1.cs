using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    interface IDiskFace

    {
        string contents { get; set; } //represents the conten
        int discSpeed { get; set; }
        string discType { get; set; }
        string discName { get; set; }
        int discCapacity { get; set; }

        public void diskSpin()
        {
            //return "Disk spinning";
        }
        public void writeDisk(string contents)
        {
        }
        //should report info back like name capacity contents and disktype
        public void ReadDisc()
        {
        }
    }
}
