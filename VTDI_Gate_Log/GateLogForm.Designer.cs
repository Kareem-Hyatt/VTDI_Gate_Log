namespace VTDI_Gate_Log
{
    partial class GateLogForm
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lbl_vehicleType = new System.Windows.Forms.Label();
            this.tb_vehicleType = new System.Windows.Forms.TextBox();
            this.lbl_plateNum = new System.Windows.Forms.Label();
            this.tb_plateNum = new System.Windows.Forms.TextBox();
            this.lbl_purpose = new System.Windows.Forms.Label();
            this.lbl_timeInOut = new System.Windows.Forms.Label();
            this.lbl_dateInOut = new System.Windows.Forms.Label();
            this.lbl_items = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cb_Purpose = new System.Windows.Forms.ComboBox();
            this.purposeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vtdi_Gate_DatabaseDataSet2 = new VTDI_Gate_Log.Vtdi_Gate_DatabaseDataSet2();
            this.cb_Declare = new System.Windows.Forms.ComboBox();
            this.declareBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vtdi_Gate_DatabaseDataSet3 = new VTDI_Gate_Log.Vtdi_Gate_DatabaseDataSet3();
            this.purposeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.declareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vtdi_Gate_DatabaseDataSet1 = new VTDI_Gate_Log.Vtdi_Gate_DatabaseDataSet1();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.declareTableAdapter = new VTDI_Gate_Log.Vtdi_Gate_DatabaseDataSet1TableAdapters.DeclareTableAdapter();
            this.purposeTableAdapter1 = new VTDI_Gate_Log.Vtdi_Gate_DatabaseDataSet2TableAdapters.PurposeTableAdapter();
            this.declareTableAdapter1 = new VTDI_Gate_Log.Vtdi_Gate_DatabaseDataSet3TableAdapters.DeclareTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purposeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtdi_Gate_DatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.declareBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtdi_Gate_DatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purposeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.declareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtdi_Gate_DatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Chiller", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_title.Location = new System.Drawing.Point(290, 17);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(217, 66);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "Gate Login";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Chiller", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(3, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(66, 34);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Chiller", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(215, 3);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(476, 42);
            this.tb_name.TabIndex = 0;
            // 
            // lbl_vehicleType
            // 
            this.lbl_vehicleType.AutoSize = true;
            this.lbl_vehicleType.Font = new System.Drawing.Font("Chiller", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vehicleType.Location = new System.Drawing.Point(3, 63);
            this.lbl_vehicleType.Name = "lbl_vehicleType";
            this.lbl_vehicleType.Size = new System.Drawing.Size(138, 34);
            this.lbl_vehicleType.TabIndex = 2;
            this.lbl_vehicleType.Text = "Vehicle Type";
            // 
            // tb_vehicleType
            // 
            this.tb_vehicleType.Font = new System.Drawing.Font("Chiller", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_vehicleType.Location = new System.Drawing.Point(215, 66);
            this.tb_vehicleType.Name = "tb_vehicleType";
            this.tb_vehicleType.Size = new System.Drawing.Size(476, 42);
            this.tb_vehicleType.TabIndex = 3;
            // 
            // lbl_plateNum
            // 
            this.lbl_plateNum.AutoSize = true;
            this.lbl_plateNum.Font = new System.Drawing.Font("Chiller", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_plateNum.Location = new System.Drawing.Point(3, 126);
            this.lbl_plateNum.Name = "lbl_plateNum";
            this.lbl_plateNum.Size = new System.Drawing.Size(144, 34);
            this.lbl_plateNum.TabIndex = 4;
            this.lbl_plateNum.Text = "Plate Number";
            // 
            // tb_plateNum
            // 
            this.tb_plateNum.Font = new System.Drawing.Font("Chiller", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_plateNum.Location = new System.Drawing.Point(215, 129);
            this.tb_plateNum.Name = "tb_plateNum";
            this.tb_plateNum.Size = new System.Drawing.Size(476, 42);
            this.tb_plateNum.TabIndex = 5;
            // 
            // lbl_purpose
            // 
            this.lbl_purpose.AutoSize = true;
            this.lbl_purpose.Font = new System.Drawing.Font("Chiller", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purpose.Location = new System.Drawing.Point(3, 189);
            this.lbl_purpose.Name = "lbl_purpose";
            this.lbl_purpose.Size = new System.Drawing.Size(88, 34);
            this.lbl_purpose.TabIndex = 6;
            this.lbl_purpose.Text = "Purpose";
            // 
            // lbl_timeInOut
            // 
            this.lbl_timeInOut.AutoSize = true;
            this.lbl_timeInOut.Font = new System.Drawing.Font("Chiller", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timeInOut.Location = new System.Drawing.Point(3, 252);
            this.lbl_timeInOut.Name = "lbl_timeInOut";
            this.lbl_timeInOut.Size = new System.Drawing.Size(149, 34);
            this.lbl_timeInOut.TabIndex = 8;
            this.lbl_timeInOut.Text = "Date/Time In";
            // 
            // lbl_dateInOut
            // 
            this.lbl_dateInOut.AutoSize = true;
            this.lbl_dateInOut.Font = new System.Drawing.Font("Chiller", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateInOut.Location = new System.Drawing.Point(3, 315);
            this.lbl_dateInOut.Name = "lbl_dateInOut";
            this.lbl_dateInOut.Size = new System.Drawing.Size(162, 34);
            this.lbl_dateInOut.TabIndex = 10;
            this.lbl_dateInOut.Text = "Date/Time Out";
            // 
            // lbl_items
            // 
            this.lbl_items.AutoSize = true;
            this.lbl_items.Font = new System.Drawing.Font("Chiller", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_items.Location = new System.Drawing.Point(3, 378);
            this.lbl_items.Name = "lbl_items";
            this.lbl_items.Size = new System.Drawing.Size(206, 34);
            this.lbl_items.TabIndex = 12;
            this.lbl_items.Text = "Item(s) To Declare";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_items, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_dateInOut, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_timeInOut, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_purpose, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_plateNum, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_plateNum, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_vehicleType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_vehicleType, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_Purpose, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cb_Declare, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(47, 90);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(703, 447);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Chiller", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(215, 318);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(476, 42);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Chiller", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(215, 255);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(476, 42);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // cb_Purpose
            // 
            this.cb_Purpose.DataSource = this.purposeBindingSource1;
            this.cb_Purpose.DisplayMember = "Name";
            this.cb_Purpose.Font = new System.Drawing.Font("Chiller", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Purpose.FormattingEnabled = true;
            this.cb_Purpose.Location = new System.Drawing.Point(215, 192);
            this.cb_Purpose.Name = "cb_Purpose";
            this.cb_Purpose.Size = new System.Drawing.Size(476, 42);
            this.cb_Purpose.TabIndex = 14;
            this.cb_Purpose.ValueMember = "Id";
            // 
            // purposeBindingSource1
            // 
            this.purposeBindingSource1.DataMember = "Purpose";
            this.purposeBindingSource1.DataSource = this.vtdi_Gate_DatabaseDataSet2;
            // 
            // vtdi_Gate_DatabaseDataSet2
            // 
            this.vtdi_Gate_DatabaseDataSet2.DataSetName = "Vtdi_Gate_DatabaseDataSet2";
            this.vtdi_Gate_DatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_Declare
            // 
            this.cb_Declare.DataSource = this.declareBindingSource1;
            this.cb_Declare.DisplayMember = "Name";
            this.cb_Declare.Font = new System.Drawing.Font("Chiller", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Declare.FormattingEnabled = true;
            this.cb_Declare.Location = new System.Drawing.Point(215, 381);
            this.cb_Declare.Name = "cb_Declare";
            this.cb_Declare.Size = new System.Drawing.Size(476, 42);
            this.cb_Declare.TabIndex = 15;
            this.cb_Declare.ValueMember = "Id";
            // 
            // declareBindingSource1
            // 
            this.declareBindingSource1.DataMember = "Declare";
            this.declareBindingSource1.DataSource = this.vtdi_Gate_DatabaseDataSet3;
            // 
            // vtdi_Gate_DatabaseDataSet3
            // 
            this.vtdi_Gate_DatabaseDataSet3.DataSetName = "Vtdi_Gate_DatabaseDataSet3";
            this.vtdi_Gate_DatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purposeBindingSource
            // 
            this.purposeBindingSource.DataMember = "Purpose";
            // 
            // declareBindingSource
            // 
            this.declareBindingSource.DataMember = "Declare";
            this.declareBindingSource.DataSource = this.vtdi_Gate_DatabaseDataSet1;
            // 
            // vtdi_Gate_DatabaseDataSet1
            // 
            this.vtdi_Gate_DatabaseDataSet1.DataSetName = "Vtdi_Gate_DatabaseDataSet1";
            this.vtdi_Gate_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Font = new System.Drawing.Font("Chiller", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.Location = new System.Drawing.Point(531, 548);
            this.Btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(84, 38);
            this.Btn_Cancel.TabIndex = 8;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Font = new System.Drawing.Font("Chiller", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Submit.Location = new System.Drawing.Point(634, 548);
            this.Btn_Submit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(84, 38);
            this.Btn_Submit.TabIndex = 7;
            this.Btn_Submit.Text = "Submit";
            this.Btn_Submit.UseVisualStyleBackColor = true;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // declareTableAdapter
            // 
            this.declareTableAdapter.ClearBeforeFill = true;
            // 
            // purposeTableAdapter1
            // 
            this.purposeTableAdapter1.ClearBeforeFill = true;
            // 
            // declareTableAdapter1
            // 
            this.declareTableAdapter1.ClearBeforeFill = true;
            // 
            // GateLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 668);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GateLogForm";
            this.Text = "Gate Log";
            this.Load += new System.EventHandler(this.GateLogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purposeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtdi_Gate_DatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.declareBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtdi_Gate_DatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purposeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.declareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtdi_Gate_DatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_vehicleType;
        private System.Windows.Forms.TextBox tb_vehicleType;
        private System.Windows.Forms.Label lbl_plateNum;
        private System.Windows.Forms.TextBox tb_plateNum;
        private System.Windows.Forms.Label lbl_purpose;
        private System.Windows.Forms.Label lbl_timeInOut;
        private System.Windows.Forms.Label lbl_dateInOut;
        private System.Windows.Forms.Label lbl_items;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.ComboBox cb_Purpose;
        private System.Windows.Forms.BindingSource purposeBindingSource;
        private System.Windows.Forms.ComboBox cb_Declare;
        private Vtdi_Gate_DatabaseDataSet1 vtdi_Gate_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource declareBindingSource;
        private Vtdi_Gate_DatabaseDataSet1TableAdapters.DeclareTableAdapter declareTableAdapter;
        private Vtdi_Gate_DatabaseDataSet2 vtdi_Gate_DatabaseDataSet2;
        private System.Windows.Forms.BindingSource purposeBindingSource1;
        private Vtdi_Gate_DatabaseDataSet2TableAdapters.PurposeTableAdapter purposeTableAdapter1;
        private Vtdi_Gate_DatabaseDataSet3 vtdi_Gate_DatabaseDataSet3;
        private System.Windows.Forms.BindingSource declareBindingSource1;
        private Vtdi_Gate_DatabaseDataSet3TableAdapters.DeclareTableAdapter declareTableAdapter1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }

}