using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CreeperWatch
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
			MineAdmin adm = new MineAdmin();
			adm.Loop();
        }
    }
}
