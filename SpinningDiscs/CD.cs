using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
       /*
        string Contents;
        int DiscSpeed = 500;
        string DiscType = "CD";
        string DiscName;
        string DiscCapacity = "1Gb" ;
       */
        public CD(string discName) : base(discName)
        {
            
            DiscSpeed = 500;
            DiscType = "CD";
            DiscName = discName;
            DiscCapacity = "1Gb";
        }

        //should report info back like name capacity contents and disktype



    }
}
