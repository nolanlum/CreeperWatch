using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace CreeperWatch
{
	public class RCONProtocol
	{
		private const int SERVERDATA_EXECCOMMAND = 2, SERVERDATA_AUTH = 3;
		private const int SERVERDATA_RESPONSE_VALUE = 0, SERVERDATA_AUTH_RESPONSE = 2;

		private const int SOCK_BUF = 4096;

		private Socket sock;
		private byte[] buf;

		private State state;

		public string ServerName { get; private set; }
		public int ServerPort { get; private set; }
		public string ServerPassword { get; private set; }

		public event Action<string> OnError;
		public event Action<string, string> OnData;

		public RCONProtocol(string address, int port, string pass)
		{
			this.ServerName = address;
			this.ServerPort = port;
			this.ServerPassword = pass;

			this.buf = new byte[SOCK_BUF];
			this.state = State.DISCONNECTED;
		}

		public void Connect()
		{
			this.sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			this.sock.Connect(new IPEndPoint(Dns.GetHostAddresses(this.ServerName)[0], this.ServerPort));

			this.state = State.CONNECTED;

			this.sock.BeginReceive(buf, 0, SOCK_BUF, SocketFlags.None, new AsyncCallback(this.dataReceived), buf);
		}

		private void handshake()
		{
			using (MemoryStream ms = new MemoryStream())
			{
				using (BinaryWriter w = new BinaryWriter(ms, Encoding.UTF8))
				{
					w.Write(0xDEADBEEF);
					w.Write(SERVERDATA_AUTH);
					w.WriteASCIIZ(this.ServerPassword);
					w.Write('\0');
				}

				byte[] pack = new byte[ms.Length + 4];
				Array.Copy(BitConverter.GetBytes(pack.Length - 4), pack, 4);
				Array.Copy(ms.GetBuffer(), 0, pack, 4, pack.Length - 4);

				this.sock.Send(pack);
			}
		}

		private void dataReceived(IAsyncResult iar)
		{
			int l = this.sock.EndReceive(iar);
			if (l < 0) return;

			byte[] d = new byte[l];
			Array.Copy(buf, d, l);

			this.sock.BeginReceive(buf, 0, SOCK_BUF, SocketFlags.None, new AsyncCallback(this.dataReceived), buf);

			using (MemoryStream ms = new MemoryStream(buf))
			{
				using (BinaryReader br = new BinaryReader(ms, Encoding.UTF8))
				{
					uint len = br.ReadUInt32();
					uint rqId = br.ReadUInt32();
					uint type = br.ReadUInt32();

					if (this.state == State.CONNECTED)
					{
						if (type == SERVERDATA_RESPONSE_VALUE)
							return;
						else if (type == SERVERDATA_AUTH_RESPONSE)
							if (rqId == 0xDEADBEEF)
								this.state = State.AUTHENTICATED;
							else if (rqId == 0xFFFFFFFF)
							{
								if (this.OnError != null)
									this.OnError("Authentication failed: bad username/password");

								this.sock.Close();
								this.state = State.DISCONNECTED;
							}
							else
								this.handshake();
					}
					else if (this.state == State.AUTHENTICATED)
					{
						if (type == SERVERDATA_RESPONSE_VALUE)
							if (this.OnData != null)
								this.OnData(br.ReadASCIIZ(), br.ReadASCIIZ());
					}
				}
			}
		}

		private enum State
		{
			DISCONNECTED,
			CONNECTED,
			AUTHENTICATED
		};
	}

	static class Extensions
	{
		public static void WriteASCIIZ(this BinaryWriter b, string s)
		{
			b.Write(Encoding.UTF8.GetBytes(s));
			b.Write('\0');
		}

		public static string ReadASCIIZ(this BinaryReader b)
		{
			StringBuilder sb = new StringBuilder();
			char c;

			while ((c = b.ReadChar()) != '\0')
				sb.Append(c);

			return sb.ToString();
		}
	}
}
