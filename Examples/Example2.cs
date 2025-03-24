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
    public partial class Example2 : Form
    {
        public Example2()
        {
            InitializeComponent();
        }
        public void Example2_Load(object sender, EventArgs e)
        {

            labelPlaceholder.Text = "";
            buttonShowText.Enabled = false;
            buttonClearText.Enabled = false;
            textBoxInput1.TextChanged += TextBoxInput_TextChanged;
        }



        private void buttonShowText_Click(object sender, EventArgs e)
        {
            string result = textBoxInput1.Text;
            string result2 = textBoxInput2.Text;

            textBoxResult.Text = result+result2;
            labelPlaceholder.Text = result+result2;
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
    }
}
