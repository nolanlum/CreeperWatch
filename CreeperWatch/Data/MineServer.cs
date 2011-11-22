using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreeperWatch.Data {
	public class MineServer
	{
		private HashSet<string> userList;

		private RCONProtocol servConn;

		public Guid GUID { get; private set; }

		public string Name { get; set; }
		public string Address { get; set; }
		public int Port { get; set; }
		public string RconPassword { get; set; }

		public List<string> Users
		{ 
			get { return this.userList.ToList(); }
		}

		public MineServer(string name, string address, int port, string pass, Guid guid)
		{
			this.Name = name;
			this.Address = address;
			this.Port = port;
			this.RconPassword = pass;

			this.GUID = guid == Guid.Empty ? Guid.NewGuid() : guid;

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

		public override string ToString()
		{
			return string.Format("{0},{1},{2},{3},{4}", this.GUID, this.Name, this.Address, this.Port, this.RconPassword);
		}

		public override bool Equals(object obj)
		{
			if (object.ReferenceEquals(this, obj))
				return true;
			if (object.ReferenceEquals(obj, null))
				return false;
			if (!(obj is MineServer))
				return false;

			return ((MineServer) obj).GUID == this.GUID;
		}

		public override int GetHashCode()
		{
			return this.GUID.GetHashCode();
		}
	}
}
