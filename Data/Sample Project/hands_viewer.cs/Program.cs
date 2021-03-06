﻿/*******************************************************************************

INTEL CORPORATION PROPRIETARY INFORMATION
This software is supplied under the terms of a license agreement or nondisclosure
agreement with Intel Corporation and may not be copied or disclosed except in
accordance with the terms of that agreement
Copyright(c) 2013 Intel Corporation. All Rights Reserved.

*******************************************************************************/
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hands_viewer.cs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Serializer ser = new Serializer();
            SignGesture gest = ser.DeSerializeObject("blub");
            Console.WriteLine((float)gest.Data.Last().middleFingerVelocity.x);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PXCMSession session = null;
            session = PXCMSession.CreateInstance();
            if (session != null)
            {
                Application.Run(new MainForm(session));
                session.Dispose();
            }

        }
    }
}
