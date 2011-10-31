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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("CreeperWatch");
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.mnuFileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.StatusStrip = new System.Windows.Forms.StatusStrip();
			this.lblBotStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.botProgress = new System.Windows.Forms.ToolStripProgressBar();
			this.mnuServerMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.ViewContainer = new System.Windows.Forms.SplitContainer();
			this.tvServers = new System.Windows.Forms.TreeView();
			this.ServerTabs = new System.Windows.Forms.TabControl();
			this.InfoTab = new System.Windows.Forms.TabPage();
			this.ActionTab = new System.Windows.Forms.TabPage();
			this.ConsoleTab = new System.Windows.Forms.TabPage();
			this.MainMenu.SuspendLayout();
			this.StatusStrip.SuspendLayout();
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
			this.mnuFileMenu.Text = "File";
			// 
			// mnuExit
			// 
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.Size = new System.Drawing.Size(152, 22);
			this.mnuExit.Text = "Exit";
			// 
			// StatusStrip
			// 
			this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblBotStatus,
            this.botProgress});
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
			// mnuServerMenu
			// 
			this.mnuServerMenu.Name = "mnuServerMenu";
			this.mnuServerMenu.Size = new System.Drawing.Size(51, 20);
			this.mnuServerMenu.Text = "Server";
			// 
			// mnuHelpMenu
			// 
			this.mnuHelpMenu.Name = "mnuHelpMenu";
			this.mnuHelpMenu.Size = new System.Drawing.Size(44, 20);
			this.mnuHelpMenu.Text = "Help";
			// 
			// ViewContainer
			// 
			this.ViewContainer.Dock = System.Windows.Forms.DockStyle.Fill;
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
			this.tvServers.Location = new System.Drawing.Point(3, 3);
			this.tvServers.Name = "tvServers";
			treeNode1.Name = "CreeperWatch";
			treeNode1.Text = "CreeperWatch";
			this.tvServers.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
			this.tvServers.Size = new System.Drawing.Size(260, 548);
			this.tvServers.TabIndex = 0;
			// 
			// ServerTabs
			// 
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.ViewContainer);
			this.Controls.Add(this.StatusStrip);
			this.Controls.Add(this.MainMenu);
			this.MainMenuStrip = this.MainMenu;
			this.Name = "MainForm";
			this.Text = "CreeperWatch";
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.StatusStrip.ResumeLayout(false);
			this.StatusStrip.PerformLayout();
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
    }
}

