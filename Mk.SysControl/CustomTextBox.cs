using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mk.SysControl
{
    class CustomTextBox : UserControl
    {
        [Browsable(true)]
        [Category("Extended Properties")]
        [Description("Set TextBox placeHolder Text")]

        private string placeHolderText {
            get;
            set;
        }
        TextBox textBox = new TextBox();

        public void setTextPlaceHolder(string text)
        {
            textBox.GotFocus += Box_GotFocus;
            textBox.LostFocus += Box_LostFocus;
        }

        private void Box_GotFocus(object sender, EventArgs e)
        {
           if (textBox.Text == placeHolderText)
                textBox.Text = String.Empty;
        }

        private void Box_LostFocus(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox.Text))
                textBox.Text = placeHolderText;
        }

    }
}
