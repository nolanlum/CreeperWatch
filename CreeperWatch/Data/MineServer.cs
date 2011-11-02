using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreeperWatch.Data {
	class MineServer
	{
		private HashSet<string> userList;

		private RCONProtocol servConn;

		public string Name { get; set; }
		public string Address { get; set; }
		public int Port { get; set; }
		public string RconPassword { get; set; }

		public List<string> Users
		{ 
			get { return this.userList.ToList(); }
		}

		public MineServer(string name, int port, string pass)
		{
			this.Name = name;
			this.Port = port;
			this.RconPassword = pass;

			this.userList = new HashSet<string>();
		}

		public void Connect(MineAdmin a)
		{
			this.servConn = new RCONProtocol(this.Address, this.Port, this.RconPassword);
			this.servConn.Connect();

			this.servConn.OnData += new Action<string,string>(a.ServerDataReceived);
			this.servConn.OnError += new Action<string>(a.ServerError);
		}

		public bool SyncUserList(List<string> users)
		{
			bool added = false;

			lock (this.userList)
			{
				foreach (string u in users)
					if (!this.userList.Contains(u))
						added |= this.userList.Add(u);
			}

			return added;
		}
	}
}
