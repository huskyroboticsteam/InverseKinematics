﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InverseKinematics
{
    class Program
    {
        static void Main(string[] args)
        {
            //For 2D
            //DrawingWindow window = new DrawingWindow();
            //For 3D
            _3D window = new _3D();
            Application.Run(window);
        }
    }
}
