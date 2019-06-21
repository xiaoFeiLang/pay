﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardRecharge
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form_Login login = new Form_Login();
            login.ShowDialog();
            if(login.DialogResult == DialogResult.OK)
            {
                login.Dispose();
                login.Close();
                Application.Run(new Form_Login());

            }
        }
    }
}
