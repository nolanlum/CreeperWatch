using System.Windows.Forms;

namespace CreeperWatch.Forms
{
	public partial class ConfirmDialog : Form
	{
		public ConfirmDialog(string messageText = null, string dialogTitle = null)
		{
			InitializeComponent();

			if (messageText != null)
				this.lblText.Text = messageText;
			if (dialogTitle != null)
				this.lblTitle.Text = this.Text = dialogTitle;
		}

	}
}
