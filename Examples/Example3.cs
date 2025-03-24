using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CruzWinForms.Examples
{
    public partial class Example3 : Form
    {
        public Example3()
        {
            InitializeComponent();
        }

        private void Example3_Load(object sender, EventArgs e)
        {
            labelPlaceholder.Text = "";
            buttonShowText.Enabled = false;
            buttonClearText.Enabled = false;
            textBoxInput1.TextChanged += TextBoxInput_TextChanged;
        }


        private void buttonShowText_Click(object sender, EventArgs e)
        {
            string input = textBoxInput1.Text;
            string input2 = textBoxInput2.Text;

            float sum = 0;


            if (float.TryParse(input, out float num1) && float.TryParse(input2, out float num2)){ 
                sum = num1 + num2;
            } 

            textBoxResult.Text = sum.ToString();

        }

        private void buttonClearText_Click(object sender, EventArgs e)
        {
            textBoxInput1.Text = "";
            textBoxInput2.Text = "";
            textBoxResult.Text = "";
            labelPlaceholder.Text = "";

        }

        private void TextBoxInput_TextChanged(object sender, EventArgs e)
        {
            buttonShowText.Enabled = !string.IsNullOrWhiteSpace(textBoxInput1.Text) && !string.IsNullOrWhiteSpace(textBoxInput2.Text);
            buttonClearText.Enabled = !string.IsNullOrWhiteSpace(textBoxInput1.Text) && !string.IsNullOrWhiteSpace(textBoxInput2.Text);

        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
        }


    }
}
