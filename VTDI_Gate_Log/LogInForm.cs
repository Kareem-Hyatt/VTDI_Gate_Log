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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            var username = tb_user_name.Text;
            var password = tb_password.Text;

            if(username == "Kedon" && password == "ABC123")
            //OR if(String.Compare("Kedon",username) && String.Compare("ABC123",password)
            {
                MessageBox.Show("Successful login " + tb_user_name.Text);
                var parent = (Form1)MdiParent;
                //OR
                //var parent = MdiParent is Form1;
                parent.isLoggedIn = true;
                Close();
            }
            else
            {
                MessageBox.Show("Please try again!");
            }
        }
    }
}
