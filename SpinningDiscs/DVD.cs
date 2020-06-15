using System;
using System.Collections.Generic;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        public DVD(string discName) : base(discName)
        {

            DiscSpeed = 1000;
            DiscType = "DVD";
            DiscName = discName;
            DiscCapacity = "8Gb";
        }
    }
}
