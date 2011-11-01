namespace CreeperWatch
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
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("CreeperWatch");
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.mnuFileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuServerMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAddServer = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuDisconnectServer = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.StatusStrip = new System.Windows.Forms.StatusStrip();
			this.lblBotStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.botProgress = new System.Windows.Forms.ToolStripProgressBar();
			this.ViewContainer = new System.Windows.Forms.SplitContainer();
			this.tvServers = new System.Windows.Forms.TreeView();
			this.ServerTabs = new System.Windows.Forms.TabControl();
			this.InfoTab = new System.Windows.Forms.TabPage();
			this.ActionTab = new System.Windows.Forms.TabPage();
			this.ConsoleTab = new System.Windows.Forms.TabPage();
			this.removeServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuRemoveServer = new System.Windows.Forms.ToolStripMenuItem();
			this.nothingHereButUsChickensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MainMenu.SuspendLayout();
			this.ViewContainer.Panel1.SuspendLayout();
			this.ViewContainer.Panel2.SuspendLayout();
			this.ViewContainer.SuspendLayout();
			this.ServerTabs.SuspendLayout();
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
			this.mnuExit.Size = new System.Drawing.Size(152, 22);
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
			// mnuHelpMenu
			// 
			this.mnuHelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nothingHereButUsChickensToolStripMenuItem});
			this.mnuHelpMenu.Name = "mnuHelpMenu";
			this.mnuHelpMenu.Size = new System.Drawing.Size(44, 20);
			this.mnuHelpMenu.Text = "&Help";
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
			this.tvServers.Location = new System.Drawing.Point(3, 3);
			this.tvServers.Name = "tvServers";
			treeNode5.Name = "CreeperWatch";
			treeNode5.Text = "CreeperWatch";
			this.tvServers.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
			this.tvServers.Size = new System.Drawing.Size(260, 548);
			this.tvServers.TabIndex = 0;
			// 
			// ServerTabs
			// 
			this.ServerTabs.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ServerTabs.Controls.Add(this.InfoTab);
			this.ServerTabs.Controls.Add(this.ActionTab);
			this.ServerTabs.Controls.Add(this.ConsoleTab);
			this.ServerTabs.Location = new System.Drawing.Point(3, 3);
			this.ServerTabs.Name = "ServerTabs";
			this.ServerTabs.SelectedIndex = 0;
			this.ServerTabs.Size = new System.Drawing.Size(524, 548);
			this.ServerTabs.TabIndex = 0;
			// 
			// InfoTab
			// 
			this.InfoTab.Location = new System.Drawing.Point(4, 22);
			this.InfoTab.Name = "InfoTab";
			this.InfoTab.Padding = new System.Windows.Forms.Padding(3);
			this.InfoTab.Size = new System.Drawing.Size(516, 522);
			this.InfoTab.TabIndex = 0;
			this.InfoTab.Text = "Info";
			this.InfoTab.UseVisualStyleBackColor = true;
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
			this.ConsoleTab.Location = new System.Drawing.Point(4, 22);
			this.ConsoleTab.Name = "ConsoleTab";
			this.ConsoleTab.Size = new System.Drawing.Size(516, 522);
			this.ConsoleTab.TabIndex = 2;
			this.ConsoleTab.Text = "Console";
			this.ConsoleTab.UseVisualStyleBackColor = true;
			// 
			// removeServerToolStripMenuItem
			// 
			this.removeServerToolStripMenuItem.Name = "removeServerToolStripMenuItem";
			this.removeServerToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.removeServerToolStripMenuItem.Text = "Remove Server";
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
			// nothingHereButUsChickensToolStripMenuItem
			// 
			this.nothingHereButUsChickensToolStripMenuItem.Name = "nothingHereButUsChickensToolStripMenuItem";
			this.nothingHereButUsChickensToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
			this.nothingHereButUsChickensToolStripMenuItem.Text = "Nothing here but us chickens!";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.ViewContainer);
			this.Controls.Add(this.StatusStrip);
			this.Controls.Add(this.MainMenu);
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
    }
}

