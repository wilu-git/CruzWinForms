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
    public partial class Example5 : Form
    {
        public Example5()
        {
            InitializeComponent();
        }

        public void Example5_Load( object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                labelYouSelected.Text = "You Selected CpE";
                textBox1.Text = "Computer Engineering"; 
            }
            else
            {
                labelYouSelected.Text = "You Selected EcE";
                textBox1.Text = "Electronic and Communication Engineering";
            }
        }

        private void radioButton1_Checked(object sender, EventArgs e)
        {

        }
    }
}
