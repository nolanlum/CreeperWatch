namespace CreeperWatch.Forms
{
	partial class AddEditServerDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtServerName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtServerAddress = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.numRconPort = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.txtRconPassword = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize) (this.numRconPort)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Server Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.label2.Location = new System.Drawing.Point(114, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(214, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Add Minecraft Server";
			// 
			// txtServerName
			// 
			this.txtServerName.Location = new System.Drawing.Point(100, 43);
			this.txtServerName.Name = "txtServerName";
			this.txtServerName.Size = new System.Drawing.Size(330, 20);
			this.txtServerName.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Server Address:";
			// 
			// txtServerAddress
			// 
			this.txtServerAddress.Location = new System.Drawing.Point(100, 85);
			this.txtServerAddress.Name = "txtServerAddress";
			this.txtServerAddress.Size = new System.Drawing.Size(330, 20);
			this.txtServerAddress.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "RCON Port:";
			// 
			// numRconPort
			// 
			this.numRconPort.Location = new System.Drawing.Point(81, 129);
			this.numRconPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.numRconPort.Name = "numRconPort";
			this.numRconPort.Size = new System.Drawing.Size(57, 20);
			this.numRconPort.TabIndex = 6;
			this.numRconPort.Value = new decimal(new int[] {
            25575,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(175, 131);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "RCON Password:";
			// 
			// txtRconPassword
			// 
			this.txtRconPassword.Location = new System.Drawing.Point(271, 128);
			this.txtRconPassword.Name = "txtRconPassword";
			this.txtRconPassword.Size = new System.Drawing.Size(159, 20);
			this.txtRconPassword.TabIndex = 8;
			this.txtRconPassword.UseSystemPasswordChar = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(108, 163);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(110, 45);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(224, 163);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(110, 45);
			this.btnOk.TabIndex = 9;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			// 
			// AddEditServerDialog
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(442, 220);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.txtRconPassword);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.numRconPort);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtServerAddress);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtServerName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = global::CreeperWatch.Properties.Resources.minekarftIcon;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddEditServerDialog";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Add Server";
			((System.ComponentModel.ISupportInitialize) (this.numRconPort)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtServerName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtServerAddress;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numRconPort;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtRconPassword;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOk;
	}
}