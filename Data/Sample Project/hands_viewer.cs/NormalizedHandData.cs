using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;

[Serializable()]

    class NormalizedHandData
    {
        public PXCMPoint3DF32 middleFingerPositionWorld;
        public PXCMPoint3DF32 palmPositionWorld;

        public PXCMPoint3DF32 middleFingerVelocity;
        public PXCMPoint3DF32 palmVelocity;


        NormalizedHandData(PXCMHandData.IHand handData) {
            PXCMHandData.JointData j;
            handData.QueryNormalizedJoint(PXCMHandData.JointType.JOINT_MIDDLE_TIP, out j);
            middleFingerPositionWorld = j.positionWorld;
            middleFingerVelocity = j.speed;
            handData.QueryNormalizedJoint(PXCMHandData.JointType.JOINT_CENTER, out j);
            palmPositionWorld = j.positionWorld;
            palmVelocity = j.speed;
           
        }
    }

