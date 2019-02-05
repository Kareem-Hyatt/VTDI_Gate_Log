namespace VTDI_Gate_Log
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gateLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gateInOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gateReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schedulingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagmentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManagmentToolStripMenuItem,
            this.gateLogsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userManagmentToolStripMenuItem
            // 
            this.userManagmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.schedulingToolStripMenuItem,
            this.alertsToolStripMenuItem,
            this.userManagmentToolStripMenuItem1});
            this.userManagmentToolStripMenuItem.Name = "userManagmentToolStripMenuItem";
            this.userManagmentToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.userManagmentToolStripMenuItem.Text = "Users";
            // 
            // gateLogsToolStripMenuItem
            // 
            this.gateLogsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guestListToolStripMenuItem,
            this.gateInOutToolStripMenuItem});
            this.gateLogsToolStripMenuItem.Name = "gateLogsToolStripMenuItem";
            this.gateLogsToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.gateLogsToolStripMenuItem.Text = "Gate Logs";
            // 
            // guestListToolStripMenuItem
            // 
            this.guestListToolStripMenuItem.Name = "guestListToolStripMenuItem";
            this.guestListToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.guestListToolStripMenuItem.Text = "Guest List";
            this.guestListToolStripMenuItem.Click += new System.EventHandler(this.guestListToolStripMenuItem_Click);
            // 
            // gateInOutToolStripMenuItem
            // 
            this.gateInOutToolStripMenuItem.Name = "gateInOutToolStripMenuItem";
            this.gateInOutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.gateInOutToolStripMenuItem.Text = "Gate In/Out";
            this.gateInOutToolStripMenuItem.Click += new System.EventHandler(this.gateInOutToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gateReportsToolStripMenuItem,
            this.userLogsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // gateReportsToolStripMenuItem
            // 
            this.gateReportsToolStripMenuItem.Name = "gateReportsToolStripMenuItem";
            this.gateReportsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.gateReportsToolStripMenuItem.Text = "Gate Reports";
            this.gateReportsToolStripMenuItem.Click += new System.EventHandler(this.gateReportsToolStripMenuItem_Click);
            // 
            // userLogsToolStripMenuItem
            // 
            this.userLogsToolStripMenuItem.Name = "userLogsToolStripMenuItem";
            this.userLogsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.userLogsToolStripMenuItem.Text = "User Logs";
            this.userLogsToolStripMenuItem.Click += new System.EventHandler(this.userLogsToolStripMenuItem_Click);
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Image = global::VTDI_Gate_Log.Properties.Resources.User_noHalo_16x;
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.logInToolStripMenuItem.Text = "Log In";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // schedulingToolStripMenuItem
            // 
            this.schedulingToolStripMenuItem.Image = global::VTDI_Gate_Log.Properties.Resources.TaskList_16x;
            this.schedulingToolStripMenuItem.Name = "schedulingToolStripMenuItem";
            this.schedulingToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.schedulingToolStripMenuItem.Text = "Scheduling";
            this.schedulingToolStripMenuItem.Click += new System.EventHandler(this.schedulingToolStripMenuItem_Click);
            // 
            // alertsToolStripMenuItem
            // 
            this.alertsToolStripMenuItem.Image = global::VTDI_Gate_Log.Properties.Resources.Alert_16x;
            this.alertsToolStripMenuItem.Name = "alertsToolStripMenuItem";
            this.alertsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.alertsToolStripMenuItem.Text = "Alerts";
            this.alertsToolStripMenuItem.Click += new System.EventHandler(this.alertsToolStripMenuItem_Click);
            // 
            // userManagmentToolStripMenuItem1
            // 
            this.userManagmentToolStripMenuItem1.Image = global::VTDI_Gate_Log.Properties.Resources.User_cyan_7x_16x_32;
            this.userManagmentToolStripMenuItem1.Name = "userManagmentToolStripMenuItem1";
            this.userManagmentToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.userManagmentToolStripMenuItem1.Text = "User Managment";
            this.userManagmentToolStripMenuItem1.Click += new System.EventHandler(this.userManagmentToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 872);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Chiller", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "VTDI Gate Log";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userManagmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schedulingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alertsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gateLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gateInOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagmentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gateReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userLogsToolStripMenuItem;
    }
}

