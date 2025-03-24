using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CruzWinForms.Examples;

namespace CruzWinForms
{
    public partial class FormEntryPoint : Form
    {
        public FormEntryPoint()
        {
            InitializeComponent();
        }

        private void buttonExample1_Click(object sender, EventArgs e)
        {
            Example1 example1 = new Example1();
            example1.ShowDialog();
        }
        
        private void buttonExample2_Click(object sender, EventArgs e)
        {
            Example2 example2 = new Example2();
            example2.ShowDialog();
        }

        private void buttonExample3_Click(object sender, EventArgs e)
        {
            Example3 example3 = new Example3();
            example3.ShowDialog();
        }

        private void buttonExample4_Click(object sender, EventArgs e)
        {
            Example4 example4 = new Example4();
            example4.ShowDialog();
        }

        private void buttonExample5_Click(object sender, EventArgs e)
        {
            Example5 example5 = new Example5();
            example5.ShowDialog();
        }   
    }
}
