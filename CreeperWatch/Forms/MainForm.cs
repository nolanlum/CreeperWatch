using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CreeperWatch
{
    public partial class MainForm : Form
    {
		private MineAdmin backend;

        public MainForm(MineAdmin backend)
        {
			this.backend = backend;

            InitializeComponent();
        }

		private void mnuExit_Click(object sender, EventArgs e)
		{
			Application.ExitThread();
		}

    }
}
