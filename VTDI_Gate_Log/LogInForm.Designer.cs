namespace VTDI_Gate_Log
{
    partial class LogInForm
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
            this.lbl_user_name = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_user_name = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.Font = new System.Drawing.Font("Chiller", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_name.Location = new System.Drawing.Point(25, 129);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(155, 46);
            this.lbl_user_name.TabIndex = 0;
            this.lbl_user_name.Text = "User Name";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Chiller", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(25, 221);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(128, 46);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password";
            // 
            // tb_user_name
            // 
            this.tb_user_name.Font = new System.Drawing.Font("Chiller", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user_name.Location = new System.Drawing.Point(253, 120);
            this.tb_user_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_user_name.Name = "tb_user_name";
            this.tb_user_name.Size = new System.Drawing.Size(352, 53);
            this.tb_user_name.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Chiller", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(253, 212);
            this.tb_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(352, 53);
            this.tb_password.TabIndex = 3;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Chiller", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_title.Location = new System.Drawing.Point(195, 25);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(216, 66);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "User Login";
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Font = new System.Drawing.Font("Chiller", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Submit.Location = new System.Drawing.Point(521, 308);
            this.Btn_Submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(84, 39);
            this.Btn_Submit.TabIndex = 5;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Font = new System.Drawing.Font("Chiller", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.Location = new System.Drawing.Point(417, 308);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(84, 39);
            this.Btn_Cancel.TabIndex = 6;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 385);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_user_name);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_user_name);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LogInForm";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_user_name;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_user_name;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}