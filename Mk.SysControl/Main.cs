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
    public partial class Main : Form
    {
        List<TextBox> cliTextBoxesToControl = new List<TextBox>();

        public Main()
        {
            InitializeComponent();
            tabControl.Resize += TabControl_Resize;

            //Criar Função que gera um textPlaceHolder
            txtboxCliName.Text = "Nome do cliente";
            txtboxCliName.GotFocus += textBoxClearText;
            txtBoxCliEmail.Text = "Email do cliente";
            txtBoxCliEmail.GotFocus += textBoxClearText;
            txtBoxCliCPF.Text = "CPF do cliente";
            txtBoxCliCPF.GotFocus += textBoxClearText;
            
            cliTextBoxesToControl.Add(txtboxCliName);
            cliTextBoxesToControl.Add(txtBoxCliEmail);
            cliTextBoxesToControl.Add(txtBoxCliCPF);
        }

        private void textBoxClearText(object sender, EventArgs e)
        {
             (sender as TextBox).Text = "";
        }

        private void TabControl_Resize(object sender, EventArgs e)
        {
            tabControl.Size = this.Size;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Main_ResizeEnd(object sender, EventArgs e)
        {
            tabControl.Size = this.Size;
        }

        private void Main_MaximumSizeChanged(object sender, EventArgs e)
        {
            tabControl.Size = this.Size;
        }

        private void Main_MaximizedBoundsChanged(object sender, EventArgs e)
        {
            tabControl.Size = this.Size;
        }

        private void Main_AutoSizeChanged(object sender, EventArgs e)
        {
            tabControl.Size = this.Size;
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            tabControl.Size = this.Size;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(TextBox boxes in cliTextBoxesToControl)
            {
                boxes.Enabled =! boxes.Enabled; 
            }
        }
    }
}
