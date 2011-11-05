namespace CreeperWatch.Forms
{
    partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("CreeperWatch");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.mnuFileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuServerMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAddServer = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuDisconnectServer = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuRemoveServer = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.nothingHereButUsChickensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.StatusStrip = new System.Windows.Forms.StatusStrip();
			this.lblBotStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.botProgress = new System.Windows.Forms.ToolStripProgressBar();
			this.ViewContainer = new System.Windows.Forms.SplitContainer();
			this.tvServers = new System.Windows.Forms.TreeView();
			this.treeImgList = new System.Windows.Forms.ImageList(this.components);
			this.ServerTabs = new System.Windows.Forms.TabControl();
			this.InfoTab = new System.Windows.Forms.TabPage();
			this.btnPM = new System.Windows.Forms.Button();
			this.btnTeleport = new System.Windows.Forms.Button();
			this.btnGive = new System.Windows.Forms.Button();
			this.btnDeOp = new System.Windows.Forms.Button();
			this.btnOp = new System.Windows.Forms.Button();
			this.btnBan = new System.Windows.Forms.Button();
			this.btnKick = new System.Windows.Forms.Button();
			this.lstPlayerList = new System.Windows.Forms.ListBox();
			this.lblAddress = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ActionTab = new System.Windows.Forms.TabPage();
			this.ConsoleTab = new System.Windows.Forms.TabPage();
			this.txtConsoleInput = new System.Windows.Forms.TextBox();
			this.txtConsole = new System.Windows.Forms.TextBox();
			this.removeServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenu.SuspendLayout();
			this.ViewContainer.Panel1.SuspendLayout();
			this.ViewContainer.Panel2.SuspendLayout();
			this.ViewContainer.SuspendLayout();
			this.ServerTabs.SuspendLayout();
			this.InfoTab.SuspendLayout();
			this.ConsoleTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainMenu
			// 
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileMenu,
            this.mnuServerMenu,
            this.mnuHelpMenu});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(800, 24);
			this.MainMenu.TabIndex = 0;
			this.MainMenu.Text = "menuStrip1";
			// 
			// mnuFileMenu
			// 
			this.mnuFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
			this.mnuFileMenu.Name = "mnuFileMenu";
			this.mnuFileMenu.Size = new System.Drawing.Size(37, 20);
			this.mnuFileMenu.Text = "&File";
			// 
			// mnuExit
			// 
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.ShortcutKeyDisplayString = "";
			this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.mnuExit.Size = new System.Drawing.Size(134, 22);
			this.mnuExit.Text = "E&xit";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// mnuServerMenu
			// 
			this.mnuServerMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddServer,
            this.toolStripSeparator1,
            this.mnuDisconnectServer,
            this.mnuRemoveServer});
			this.mnuServerMenu.Name = "mnuServerMenu";
			this.mnuServerMenu.Size = new System.Drawing.Size(51, 20);
			this.mnuServerMenu.Text = "&Server";
			// 
			// mnuAddServer
			// 
			this.mnuAddServer.Image = global::CreeperWatch.Properties.Resources.Add;
			this.mnuAddServer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.mnuAddServer.Name = "mnuAddServer";
			this.mnuAddServer.Size = new System.Drawing.Size(184, 38);
			this.mnuAddServer.Text = "&Add Server";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
			// 
			// mnuDisconnectServer
			// 
			this.mnuDisconnectServer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.mnuDisconnectServer.Name = "mnuDisconnectServer";
			this.mnuDisconnectServer.Size = new System.Drawing.Size(184, 38);
			this.mnuDisconnectServer.Text = "&Disconnect Server";
			// 
			// mnuRemoveServer
			// 
			this.mnuRemoveServer.AutoSize = false;
			this.mnuRemoveServer.Image = global::CreeperWatch.Properties.Resources.Minus_Red_Button;
			this.mnuRemoveServer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.mnuRemoveServer.Name = "mnuRemoveServer";
			this.mnuRemoveServer.Size = new System.Drawing.Size(184, 38);
			this.mnuRemoveServer.Text = "D&elete Server";
			// 
			// mnuHelpMenu
			// 
			this.mnuHelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nothingHereButUsChickensToolStripMenuItem});
			this.mnuHelpMenu.Name = "mnuHelpMenu";
			this.mnuHelpMenu.Size = new System.Drawing.Size(44, 20);
			this.mnuHelpMenu.Text = "&Help";
			// 
			// nothingHereButUsChickensToolStripMenuItem
			// 
			this.nothingHereButUsChickensToolStripMenuItem.Name = "nothingHereButUsChickensToolStripMenuItem";
			this.nothingHereButUsChickensToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
			this.nothingHereButUsChickensToolStripMenuItem.Text = "Nothing here but us chickens!";
			// 
			// StatusStrip
			// 
			this.StatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.StatusStrip.Location = new System.Drawing.Point(0, 578);
			this.StatusStrip.Name = "StatusStrip";
			this.StatusStrip.Size = new System.Drawing.Size(800, 22);
			this.StatusStrip.TabIndex = 1;
			// 
			// lblBotStatus
			// 
			this.lblBotStatus.Name = "lblBotStatus";
			this.lblBotStatus.Size = new System.Drawing.Size(71, 17);
			this.lblBotStatus.Text = "Doing work!";
			// 
			// botProgress
			// 
			this.botProgress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.botProgress.Name = "botProgress";
			this.botProgress.Size = new System.Drawing.Size(100, 16);
			this.botProgress.Visible = false;
			// 
			// ViewContainer
			// 
			this.ViewContainer.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ViewContainer.Location = new System.Drawing.Point(0, 24);
			this.ViewContainer.Name = "ViewContainer";
			// 
			// ViewContainer.Panel1
			// 
			this.ViewContainer.Panel1.Controls.Add(this.tvServers);
			// 
			// ViewContainer.Panel2
			// 
			this.ViewContainer.Panel2.Controls.Add(this.ServerTabs);
			this.ViewContainer.Size = new System.Drawing.Size(800, 554);
			this.ViewContainer.SplitterDistance = 266;
			this.ViewContainer.TabIndex = 2;
			// 
			// tvServers
			// 
			this.tvServers.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tvServers.ImageIndex = 0;
			this.tvServers.ImageList = this.treeImgList;
			this.tvServers.Location = new System.Drawing.Point(3, 3);
			this.tvServers.Name = "tvServers";
			treeNode2.Name = "CreeperWatch";
			treeNode2.Text = "CreeperWatch";
			this.tvServers.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
			this.tvServers.SelectedImageIndex = 0;
			this.tvServers.Size = new System.Drawing.Size(260, 548);
			this.tvServers.TabIndex = 0;
			// 
			// treeImgList
			// 
			this.treeImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer) (resources.GetObject("treeImgList.ImageStream")));
			this.treeImgList.TransparentColor = System.Drawing.Color.Transparent;
			this.treeImgList.Images.SetKeyName(0, "minekarft.png");
			this.treeImgList.Images.SetKeyName(1, "minekarftgreenboi.png");
			this.treeImgList.Images.SetKeyName(2, "minekarftyella.png");
			this.treeImgList.Images.SetKeyName(3, "minekarftredyo.png");
			// 
			// ServerTabs
			// 
			this.ServerTabs.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ServerTabs.Controls.Add(this.InfoTab);
			this.ServerTabs.Controls.Add(this.ActionTab);
			this.ServerTabs.Controls.Add(this.ConsoleTab);
			this.ServerTabs.Enabled = false;
			this.ServerTabs.Location = new System.Drawing.Point(3, 3);
			this.ServerTabs.Name = "ServerTabs";
			this.ServerTabs.SelectedIndex = 0;
			this.ServerTabs.Size = new System.Drawing.Size(524, 548);
			this.ServerTabs.TabIndex = 0;
			// 
			// InfoTab
			// 
			this.InfoTab.Controls.Add(this.btnPM);
			this.InfoTab.Controls.Add(this.btnTeleport);
			this.InfoTab.Controls.Add(this.btnGive);
			this.InfoTab.Controls.Add(this.btnDeOp);
			this.InfoTab.Controls.Add(this.btnOp);
			this.InfoTab.Controls.Add(this.btnBan);
			this.InfoTab.Controls.Add(this.btnKick);
			this.InfoTab.Controls.Add(this.lstPlayerList);
			this.InfoTab.Controls.Add(this.lblAddress);
			this.InfoTab.Controls.Add(this.label2);
			this.InfoTab.Controls.Add(this.lblName);
			this.InfoTab.Controls.Add(this.label1);
			this.InfoTab.Location = new System.Drawing.Point(4, 22);
			this.InfoTab.Name = "InfoTab";
			this.InfoTab.Padding = new System.Windows.Forms.Padding(3);
			this.InfoTab.Size = new System.Drawing.Size(516, 522);
			this.InfoTab.TabIndex = 0;
			this.InfoTab.Text = "Info";
			this.InfoTab.UseVisualStyleBackColor = true;
			// 
			// btnPM
			// 
			this.btnPM.Location = new System.Drawing.Point(387, 468);
			this.btnPM.Name = "btnPM";
			this.btnPM.Size = new System.Drawing.Size(123, 42);
			this.btnPM.TabIndex = 11;
			this.btnPM.Text = "Send Private Message";
			this.btnPM.UseVisualStyleBackColor = true;
			// 
			// btnTeleport
			// 
			this.btnTeleport.Location = new System.Drawing.Point(387, 420);
			this.btnTeleport.Name = "btnTeleport";
			this.btnTeleport.Size = new System.Drawing.Size(123, 42);
			this.btnTeleport.TabIndex = 10;
			this.btnTeleport.Text = "Teleport to...";
			this.btnTeleport.UseVisualStyleBackColor = true;
			// 
			// btnGive
			// 
			this.btnGive.Location = new System.Drawing.Point(387, 372);
			this.btnGive.Name = "btnGive";
			this.btnGive.Size = new System.Drawing.Size(123, 42);
			this.btnGive.TabIndex = 9;
			this.btnGive.Text = "Give Item";
			this.btnGive.UseVisualStyleBackColor = true;
			// 
			// btnDeOp
			// 
			this.btnDeOp.Location = new System.Drawing.Point(387, 324);
			this.btnDeOp.Name = "btnDeOp";
			this.btnDeOp.Size = new System.Drawing.Size(123, 42);
			this.btnDeOp.TabIndex = 8;
			this.btnDeOp.Text = "De-op Player";
			this.btnDeOp.UseVisualStyleBackColor = true;
			// 
			// btnOp
			// 
			this.btnOp.Location = new System.Drawing.Point(387, 276);
			this.btnOp.Name = "btnOp";
			this.btnOp.Size = new System.Drawing.Size(123, 42);
			this.btnOp.TabIndex = 7;
			this.btnOp.Text = "Op Player";
			this.btnOp.UseVisualStyleBackColor = true;
			// 
			// btnBan
			// 
			this.btnBan.Location = new System.Drawing.Point(387, 228);
			this.btnBan.Name = "btnBan";
			this.btnBan.Size = new System.Drawing.Size(123, 42);
			this.btnBan.TabIndex = 6;
			this.btnBan.Text = "Ban";
			this.btnBan.UseVisualStyleBackColor = true;
			// 
			// btnKick
			// 
			this.btnKick.Location = new System.Drawing.Point(387, 180);
			this.btnKick.Name = "btnKick";
			this.btnKick.Size = new System.Drawing.Size(123, 42);
			this.btnKick.TabIndex = 5;
			this.btnKick.Text = "Kick";
			this.btnKick.UseVisualStyleBackColor = true;
			// 
			// lstPlayerList
			// 
			this.lstPlayerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.lstPlayerList.FormattingEnabled = true;
			this.lstPlayerList.ItemHeight = 16;
			this.lstPlayerList.Location = new System.Drawing.Point(6, 180);
			this.lstPlayerList.Name = "lstPlayerList";
			this.lstPlayerList.Size = new System.Drawing.Size(375, 324);
			this.lstPlayerList.TabIndex = 4;
			// 
			// lblAddress
			// 
			this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.lblAddress.Location = new System.Drawing.Point(74, 38);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new System.Drawing.Size(436, 16);
			this.lblAddress.TabIndex = 3;
			this.lblAddress.Text = "server.minecraft.com";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.label2.Location = new System.Drawing.Point(6, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Address:";
			this.label2.UseMnemonic = false;
			// 
			// lblName
			// 
			this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.lblName.Location = new System.Drawing.Point(74, 12);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(436, 16);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "MAI MEINKARFT SERVER";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.label1.Location = new System.Drawing.Point(6, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// ActionTab
			// 
			this.ActionTab.Location = new System.Drawing.Point(4, 22);
			this.ActionTab.Name = "ActionTab";
			this.ActionTab.Padding = new System.Windows.Forms.Padding(3);
			this.ActionTab.Size = new System.Drawing.Size(516, 522);
			this.ActionTab.TabIndex = 1;
			this.ActionTab.Text = "Actions";
			this.ActionTab.UseVisualStyleBackColor = true;
			// 
			// ConsoleTab
			// 
			this.ConsoleTab.Controls.Add(this.txtConsoleInput);
			this.ConsoleTab.Controls.Add(this.txtConsole);
			this.ConsoleTab.Location = new System.Drawing.Point(4, 22);
			this.ConsoleTab.Name = "ConsoleTab";
			this.ConsoleTab.Size = new System.Drawing.Size(516, 522);
			this.ConsoleTab.TabIndex = 2;
			this.ConsoleTab.Text = "Console";
			this.ConsoleTab.UseVisualStyleBackColor = true;
			// 
			// txtConsoleInput
			// 
			this.txtConsoleInput.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtConsoleInput.Location = new System.Drawing.Point(3, 499);
			this.txtConsoleInput.Name = "txtConsoleInput";
			this.txtConsoleInput.Size = new System.Drawing.Size(510, 20);
			this.txtConsoleInput.TabIndex = 1;
			// 
			// txtConsole
			// 
			this.txtConsole.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtConsole.BackColor = System.Drawing.SystemColors.Window;
			this.txtConsole.Cursor = System.Windows.Forms.Cursors.Default;
			this.txtConsole.Enabled = false;
			this.txtConsole.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.txtConsole.Location = new System.Drawing.Point(3, 3);
			this.txtConsole.Multiline = true;
			this.txtConsole.Name = "txtConsole";
			this.txtConsole.ReadOnly = true;
			this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtConsole.Size = new System.Drawing.Size(510, 490);
			this.txtConsole.TabIndex = 0;
			this.txtConsole.Text = "[INFO] Lorem ipsum.";
			// 
			// removeServerToolStripMenuItem
			// 
			this.removeServerToolStripMenuItem.Name = "removeServerToolStripMenuItem";
			this.removeServerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.removeServerToolStripMenuItem.Text = "Remove Server";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.ViewContainer);
			this.Controls.Add(this.StatusStrip);
			this.Controls.Add(this.MainMenu);
			this.Icon = global::CreeperWatch.Properties.Resources.minekarftIcon;
			this.KeyPreview = true;
			this.MainMenuStrip = this.MainMenu;
			this.Name = "MainForm";
			this.Text = "CreeperWatch";
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.ViewContainer.Panel1.ResumeLayout(false);
			this.ViewContainer.Panel2.ResumeLayout(false);
			this.ViewContainer.ResumeLayout(false);
			this.ServerTabs.ResumeLayout(false);
			this.InfoTab.ResumeLayout(false);
			this.ConsoleTab.ResumeLayout(false);
			this.ConsoleTab.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.MenuStrip MainMenu;
		private System.Windows.Forms.StatusStrip StatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel lblBotStatus;
		private System.Windows.Forms.ToolStripProgressBar botProgress;
		private System.Windows.Forms.ToolStripMenuItem mnuFileMenu;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.ToolStripMenuItem mnuServerMenu;
		private System.Windows.Forms.ToolStripMenuItem mnuHelpMenu;
		private System.Windows.Forms.SplitContainer ViewContainer;
		private System.Windows.Forms.TreeView tvServers;
		private System.Windows.Forms.TabControl ServerTabs;
		private System.Windows.Forms.TabPage InfoTab;
		private System.Windows.Forms.TabPage ActionTab;
		private System.Windows.Forms.TabPage ConsoleTab;
		private System.Windows.Forms.ToolStripMenuItem mnuAddServer;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem mnuDisconnectServer;
		private System.Windows.Forms.ToolStripMenuItem removeServerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuRemoveServer;
		private System.Windows.Forms.ToolStripMenuItem nothingHereButUsChickensToolStripMenuItem;
		private System.Windows.Forms.TextBox txtConsoleInput;
		private System.Windows.Forms.TextBox txtConsole;
		private System.Windows.Forms.ImageList treeImgList;
		private System.Windows.Forms.Button btnPM;
		private System.Windows.Forms.Button btnTeleport;
		private System.Windows.Forms.Button btnGive;
		private System.Windows.Forms.Button btnDeOp;
		private System.Windows.Forms.Button btnOp;
		private System.Windows.Forms.Button btnBan;
		private System.Windows.Forms.Button btnKick;
		private System.Windows.Forms.ListBox lstPlayerList;
		private System.Windows.Forms.Label lblAddress;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label label1;
    }
}

