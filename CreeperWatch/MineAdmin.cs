using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CreeperWatch
{
	public class MineAdmin
	{
		private List<MineServer> servers;

		private MainForm view;
		private Thread uiThread;

		public MineAdmin()
		{
			// Parsing CSV values like no tomorrow.
			string[] split = Properties.Settings.Default.ServerStrings.Split(',');
			this.servers = new List<MineServer>();

			for (int i = 0; i < split.Length; i += 3)
			{
				if (i + 2 >= split.Length) return; // wut. I didn't save data like this.
				
				this.servers.Add(new MineServer(split[i], int.Parse(split[i + 1]), split[i + 2]));
			}
		}

		public void Loop() {
			this.view = new MainForm(this);
			this.uiThread = new Thread((ThreadStart) delegate
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(this.view);
			});
			this.uiThread.SetApartmentState(ApartmentState.STA);
			
			this.uiThread.Start();
			while (this.uiThread.IsAlive) Thread.Sleep(100);
		}
	}
}
