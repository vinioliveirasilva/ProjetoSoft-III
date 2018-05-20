using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mk.SysControl
{
    public partial class Login : Form
    {

        private Main mainForm;
        public Login()
        {
            InitializeComponent();


        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            mainForm = new Main();
            mainForm.FormClosing += MainForm_FormClosing;

            this.Hide();
            mainForm.Show();
        }


    }
}
