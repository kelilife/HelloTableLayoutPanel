﻿using System;
using System.Windows.Forms;

using KeLi.HelloTableLayoutPanel.Forms;

namespace KeLi.HelloTableLayoutPanel
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}