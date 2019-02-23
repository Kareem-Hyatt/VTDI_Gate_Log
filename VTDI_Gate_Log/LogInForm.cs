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

            //ctx is an object of the database. It means "context" which is what the diagram represents
            var ctx = new Vtdi_Gate_DatabaseEntities();
            //using a lambda expression to check if the user name entered matches the user name in the database
            var user = ctx.Users.Any(q => q.UserName == username && q.Password == password);


            if (user == true)
            //OR if(String.Compare("Kedon",username) && String.Compare("ABC123",password)
            {
                MessageBox.Show("Welcome " + tb_user_name.Text);
                //OR
                //MessageBox.Show($"Welcome {username}");
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
