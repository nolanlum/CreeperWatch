using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using CreeperWatch.Data;

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

			this.Load += new EventHandler(MainForm_Load);
			this.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);

			InitializeComponent();

			this.tvServers.NodeMouseClick += new TreeNodeMouseClickEventHandler(tvServers_NodeMouseClick);
		}

		public void UpdateServerList(Dictionary<Guid, MineServer> d)
		{
			var root = this.tvServers.Nodes[0];

			var found = new HashSet<TreeNode>();
			foreach (TreeNode tn in root.Nodes)
				found.Add(tn);

			foreach(var kv in d) {
				string guid = kv.Key.ToString();

				if (root.Nodes.ContainsKey(guid))
				{
					var node = root.Nodes[guid];

					if(node.Text != kv.Value.Name) {
						node.Text = kv.Value.Name;
					}

					node.ImageIndex = 3;
					node.SelectedImageIndex = 3;

					found.Remove(node);
				} else {
					var tn = root.Nodes.Add(guid, kv.Value.Name);
					tn.Tag = kv.Key;

					tn.ImageIndex = 3;
					tn.SelectedImageIndex = 3;

					tn.ContextMenuStrip = this.ctxServer;
				}
			}

			foreach (TreeNode tn in found)
				root.Nodes.Remove(tn);

			root.Expand();
		}

		private void queueEvent(MineAction a, params object[] args)
		{
			lock (this.EventQueue)
			{
				this.EventQueue.Enqueue(new KeyValuePair<MineAction, object[]>(a, args));
			}

			this.EventHandle.Set();
		}

		private void mnuExit_Click(object sender, EventArgs e)
		{
			Application.ExitThread();
		}

		private void tvServers_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			var node = e.Node;
			var good = (node != null && node.Tag != null);

			mnuDisconnectServer.Enabled = good;
			mnuRemoveServer.Enabled = good;
			ServerTabs.Enabled = good;
		}

		private void mnuAddServer_Click(object sender, EventArgs e)
		{
			var f = new AddEditServerDialog();
			var result = f.ShowDialog();

			if (result == System.Windows.Forms.DialogResult.OK)
			{
				this.queueEvent(MineAction.ACTION_ADD_SERVER, f.ServerName, f.ServerAddress, f.ServerPassword, f.ServerPort);
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			queueEvent(MineAction.ACTION_UI_LOAD, null);
		}
		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.EventHandle.Set();
		}
    }
}
