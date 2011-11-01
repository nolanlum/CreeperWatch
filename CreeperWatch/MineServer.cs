using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreeperWatch
{
	class MineServer
	{
		private HashSet<string> userList;

		public string Name { get; set; }
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

		public bool SyncUserList(List<string> users)
		{
			bool added = false;

			foreach (string u in users)
			{
				if (!this.userList.Contains(u))
				{
					added |= this.userList.Add(u);
				}
			}

			return added;
		}
	}
}
