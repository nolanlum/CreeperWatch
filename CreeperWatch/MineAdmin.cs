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
		private Dictionary<Guid, MineServer> servers;

		private MainForm view;
		private Thread uiThread;

		public MineAdmin()
		{
			// Parsing CSV values like no tomorrow.
			string[] split = Properties.Settings.Default.ServerStrings.Split(',');
			this.servers = new Dictionary<Guid, MineServer>();

			for (int i = 0; i < split.Length; i += 5)
			{
				if (i + 4 >= split.Length) return; // wut. I didn't save data like this.

				try
				{
					var id = new Guid(split[i]);
					var s = new MineServer(split[i + 1], split[1 + 2], int.Parse(split[i + 3]), split[i + 4], id);

					this.servers.Add(id, s);
				}
				catch (Exception)
				{
					continue;
				}
			}
		}

		public void Loop()
		{
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
				this.view.EventHandle.WaitOne(1000);
			}

			this.saveServerList();
		}

		public void ServerDataReceived(string str1, string str2)
		{
		}

		public void ServerError(string error)
		{
		}

		private void saveServerList()
		{
			var sb = new StringBuilder();

			lock (this.servers)
			{
				foreach (var s in this.servers)
					sb.Append(s.Value.ToString()).Append(',');
			}

			Properties.Settings.Default.ServerStrings = sb.ToString().TrimEnd(',');
			Properties.Settings.Default.Save();
		}

		private void doEvent(MineAction ev, object[] args)
		{
			switch (ev)
			{
				case MineAction.ACTION_UI_LOAD:
					this.view.Invoke(new Action(delegate { this.view.UpdateServerList(this.servers); }));
					return;

				case MineAction.ACTION_SEND_RAW:
					return;

				case MineAction.ACTION_ADD_SERVER:
					string name = (string) args[0],
						address = (string) args[1],
						password = (string) args[2];
					int port = (int) args[3];

					MineServer s = new MineServer(name, address, port, password, Guid.Empty);

					lock (this.servers)
					{
						this.servers.Add(s.GUID, s);
					}

					this.saveServerList();
					this.view.Invoke(new Action(delegate { this.view.UpdateServerList(this.servers); }));

					return;
			}
		}
	}

	public enum MineAction
	{
		ACTION_SEND_RAW,
		ACTION_ADD_SERVER,

		ACTION_UI_LOAD,
	};
}
