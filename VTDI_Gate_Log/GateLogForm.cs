using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTDI_Gate_Log
{
    public partial class GateLogForm : Form
    {
        public GateLogForm()
        {
            InitializeComponent();
        }

        private void GateLogForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vtdi_Gate_DatabaseDataSet3.Declare' table. You can move, or remove it, as needed.
            this.declareTableAdapter1.Fill(this.vtdi_Gate_DatabaseDataSet3.Declare);
            // TODO: This line of code loads data into the 'vtdi_Gate_DatabaseDataSet2.Purpose' table. You can move, or remove it, as needed.
            this.purposeTableAdapter1.Fill(this.vtdi_Gate_DatabaseDataSet2.Purpose);
            // TODO: This line of code loads data into the 'vtdi_Gate_DatabaseDataSet1.Declare' table. You can move, or remove it, as needed.
            this.declareTableAdapter.Fill(this.vtdi_Gate_DatabaseDataSet1.Declare);
            // TODO: This line of code loads data into the 'vtdi_Gate_DatabaseDataSet.Purpose' table. You can move, or remove it, as needed.

        }

        

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            var name = tb_name.Text;
            var vehicle_type = tb_vehicleType.Text;
            var plate_num = tb_plateNum;
            var purpose = cb_Purpose.SelectedValue;
            var time_in = DateTime.Now;
            var declare = cb_Declare.SelectedValue;
        }
    }
}
