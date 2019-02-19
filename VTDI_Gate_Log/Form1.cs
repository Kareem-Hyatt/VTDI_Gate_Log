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
    public partial class Form1 : Form
    {

        public bool isLoggedIn = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Login Clicked");
            LogInForm logIn = new LogInForm();
            logIn.MdiParent = this;
            logIn.Show();

            //this code can be replaced using this

            /*
             showLogInForm();
             */
        }

        private void schedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Scheduling Clicked");
        }

        private void alertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alerts Clicked");
        }

        private void userManagmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Management Clicked");
        }

        private void guestListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guest List Clicked");
        }

        private void gateInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.isLoggedIn)
            {
                //MessageBox.Show("Gate In/Out Clicked");
                GateInOut logIn = new GateInOut();
                logIn.MdiParent = this;
                logIn.Show();
            }
            else
            {
                // MessageBox.Show("Login Clicked");
                //calling a function to do this instead of copying it everywhere
                showLogginForm();
            }
            
        }

        private void gateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gate Report Clicked");
        }

        private void userLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Logs Clicked");
        }

        private void showLogginForm()
        {
            // MessageBox.Show("Login Clicked");
            LogInForm logIn = new LogInForm();
            logIn.MdiParent = this;
            logIn.Show();
        }
    }
}
