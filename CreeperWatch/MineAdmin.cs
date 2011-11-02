using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CreeperWatch.Forms;
using CreeperWatch.Data;

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
			while (this.uiThread.IsAlive)
			{
				while (this.view.EventQueue.Count > 0)
				{
					var ev = this.view.EventQueue.Dequeue();
					doEvent(ev.Key, ev.Value);
				}

				this.view.EventHandle.Reset();
				this.view.EventHandle.WaitOne(2000);
			}
		}

		public void ServerDataReceived(string str1, string str2)
		{
		}

		public void ServerError(string error)
		{
		}

		private void doEvent(MineAction ev, object[] args)
		{
			switch (ev)
			{
				case MineAction.ACTION_SEND_RAW:
					return;
			}
		}
	}

	public enum MineAction
	{
		ACTION_SEND_RAW
	};
}
