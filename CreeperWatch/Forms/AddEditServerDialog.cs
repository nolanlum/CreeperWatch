using System.Windows.Forms;

namespace CreeperWatch.Forms
{
	public partial class AddEditServerDialog : Form
	{
		public string ServerName { get { return this.txtServerName.Text; } set { this.txtServerName.Text = value; } }
		public string ServerAddress { get { return this.txtServerAddress.Text; } set { this.txtServerAddress.Text = value; } }
		public int ServerPort { get { return (int) this.numRconPort.Value; } set { this.numRconPort.Value = value; } }
		public string ServerPassword { get { return this.txtRconPassword.Text; } set { this.txtRconPassword.Text = value; } }

		public AddEditServerDialog(bool edit = false)
		{
			InitializeComponent();

			if (edit)
				this.label2.Text = "Edit Minecraft Server";
		}
	}
}
