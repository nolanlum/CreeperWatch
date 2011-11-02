using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace CreeperWatch.Forms
{
    public partial class MainForm : Form
    {
		private MineAdmin backend;

		public Queue<KeyValuePair<MineAction, object[]>> EventQueue { get; private set; }
		public EventWaitHandle EventHandle { get; private set; }

        public MainForm(MineAdmin backend)
        {
			this.backend = backend;
			this.EventQueue = new Queue<KeyValuePair<MineAction, object[]>>();
			this.EventHandle = new ManualResetEvent(false);

            InitializeComponent();
        }

		private void mnuExit_Click(object sender, EventArgs e)
		{
			Application.ExitThread();
		}

    }
}
