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
    public partial class GateInOut : Form
    {
        public GateInOut()
        {
            InitializeComponent();
        }

        private void GateInOut_Load(object sender, EventArgs e)
        {

        }

        private void tb_name_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Mouse Hover");
        }
    }
}
