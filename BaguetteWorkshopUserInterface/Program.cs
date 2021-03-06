﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_new.Classes;
using BLL_new.Interfaces;
using System.Configuration;

namespace BaguetteWorkshopUserInterface
{
    static class Program
    {
        public static IJoinContainer container = new JoinContainer(ConfigurationManager.AppSettings.Get("Serialize path"));
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
