namespace ChatChat
{
    partial class App
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.availableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.awayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendAnInstantMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView = new System.Windows.Forms.TreeView();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileToolStripMenuItem, this.contactsToolStripMenuItem, this.actionsToolStripMenuItem, this.toolsToolStripMenuItem, this.helpToolStripMenuItem });
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(344, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.statusToolStripMenuItem });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.availableToolStripMenuItem, this.busyToolStripMenuItem, this.awayToolStripMenuItem });
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.statusToolStripMenuItem.Text = "Status";
            // 
            // availableToolStripMenuItem
            // 
            this.availableToolStripMenuItem.Name = "availableToolStripMenuItem";
            this.availableToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.availableToolStripMenuItem.Text = "Available";
            // 
            // busyToolStripMenuItem
            // 
            this.busyToolStripMenuItem.Name = "busyToolStripMenuItem";
            this.busyToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.busyToolStripMenuItem.Text = "Busy";
            // 
            // awayToolStripMenuItem
            // 
            this.awayToolStripMenuItem.Name = "awayToolStripMenuItem";
            this.awayToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.awayToolStripMenuItem.Text = "Away";
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.contactsToolStripMenuItem.Text = "Contacts";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.sendAnInstantMessageToolStripMenuItem });
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // sendAnInstantMessageToolStripMenuItem
            // 
            this.sendAnInstantMessageToolStripMenuItem.Name = "sendAnInstantMessageToolStripMenuItem";
            this.sendAnInstantMessageToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.sendAnInstantMessageToolStripMenuItem.Text = "Send an instant message";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView.Location = new System.Drawing.Point(0, 28);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(344, 637);
            this.treeView.TabIndex = 1;
            // 
            // App
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(344, 665);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 700);
            this.MinimumSize = new System.Drawing.Size(350, 700);
            this.Name = "App";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatChat";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem sendAnInstantMessageToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem availableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem awayToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip;

        #endregion

        private System.Windows.Forms.TreeView treeView;
    }
}