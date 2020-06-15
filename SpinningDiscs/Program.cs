using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            CD testCD = new CD("testCD");
            DVD testDVD = new DVD("testDVD");

            // TODO: Call each CD and DVD method to verify that they work as expected.

            testCD.DiskSpin();
            testCD.WriteDisk("WE are we are");
            testCD.ReadDisc();
            testCD.LaserSwitch(true);
            testCD.ReadDisc();

            testDVD.DiskSpin();
            testDVD.WriteDisk("WE are we are DVDS");
            testDVD.ReadDisc();
            testDVD.LaserSwitch(true);
            testDVD.ReadDisc();
        }
    }
}
