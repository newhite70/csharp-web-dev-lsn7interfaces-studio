using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public class BaseDisc 
    {
        public string Contents { get; set; }
        public int DiscSpeed { get; set; }
        public string DiscType { get; set; }
        public string DiscName { get; set; }
        public string DiscCapacity { get; set; }
        public bool Laser { get; set; } = false;

        public BaseDisc(string discName)
        {
            //DiscType = discType;
            DiscName = discName;
        }
        public void LaserSwitch(bool laser)
        {
            Laser = laser;
        }


        public void ReadDisc() 
        {
            if (Laser == true)
            {
                string stringPrinted = $"\nDisc Name: {DiscName}\nDisc Type: {DiscType}\nDisc Capacity: {DiscCapacity}\nDisc Speed: {DiscSpeed}\nContent of Disc: {Contents}";
                Console.WriteLine(stringPrinted);
            }
            else
            {
                Console.WriteLine("Laser is off, can't read media");
            }
        }

        public void DiskSpin()
        {
            Console.WriteLine($"{DiscType} spins at {DiscSpeed}rpms");
        }
        
        public void WriteDisk(string contents)
        {
            Contents = contents;
        }
        

    }
}
