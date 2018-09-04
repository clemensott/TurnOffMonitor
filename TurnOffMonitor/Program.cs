﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TurnOffMonitor
{
    class Program
    {
        static int WM_SYSCOMMAND = 0x112;
        static int SC_MONITORPOWER = 0xF170;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        private static void Main(string[] args)
        {
            Form f = new Form();
            bool turnOff = true;
            SendMessage(f.Handle, WM_SYSCOMMAND, (IntPtr)SC_MONITORPOWER, (IntPtr)(turnOff ? 2 : -1));
        }
    }
}
