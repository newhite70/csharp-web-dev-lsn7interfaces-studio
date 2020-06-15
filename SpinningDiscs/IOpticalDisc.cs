using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public interface IOpticalDisc

    {
        public string Contents { get; set; }
        public int DiscSpeed { get; set; }
        public string DiscType { get; set; }
        public string DiscName { get; set; }
        public string DiscCapacity { get; set; }
        public bool Laser { get; set; }

        public void DiskSpin()
        {
            //return "Disk spinning";
        }
        public void WriteDisk(string contents)
        {
            //Contents = contents;
        }
        //should report info back like name capacity contents and disktype
        public void ReadDisc()
        {
            //return a string
        }
    }
}
