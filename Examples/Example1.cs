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
    public partial class Example1 : Form
    {
        public Example1()
        {
            InitializeComponent();
        }
        public void Example1_Load(object sender, EventArgs e)
        {
            
            labelPlaceholder.Text = "";
            buttonShowText.Enabled = false;
            buttonClearText.Enabled = false;
            textBoxInput.TextChanged += TextBoxInput_TextChanged;
        }

        private void TextBoxInput_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonShowText_Click(object sender, EventArgs e)
        {
            string result = textBoxInput.Text;

            textBoxResult.Text = result;
            labelPlaceholder.Text = result;
        }

        private void buttonClearText_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "";
            textBoxResult.Text = "";
            labelPlaceholder.Text = "";
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            buttonShowText.Enabled = !string.IsNullOrWhiteSpace(textBoxInput.Text);
            buttonClearText.Enabled = !string.IsNullOrWhiteSpace(textBoxInput.Text);
        }
    }
}
