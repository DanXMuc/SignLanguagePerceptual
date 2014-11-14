using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;

[Serializable()]

    public class NormalizedHandData
    {
        public PXCMPoint3DF32 middleFingerPositionWorld;
        public PXCMPoint3DF32 palmPositionWorld;

        public PXCMPoint3DF32 middleFingerVelocity;
        public PXCMPoint3DF32 palmVelocity;


        public NormalizedHandData(PXCMPoint3DF32 palmVelocity, PXCMPoint3DF32 palmPositionWorld, PXCMPoint3DF32 middleFingerVelocity, PXCMPoint3DF32 middleFingerPositionWorld)
        {
            this.middleFingerPositionWorld = middleFingerPositionWorld;
            this.middleFingerVelocity = middleFingerVelocity;
            this.palmPositionWorld = palmPositionWorld;
            this.palmVelocity = palmVelocity;
           
        }
    }

