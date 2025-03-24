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
    public partial class Example4 : Form
    {
        public Example4()
        {
            InitializeComponent();

            comboBoxCourses.Items.Add("None");
            comboBoxCourses.Items.Add("EcE");
            comboBoxCourses.Items.Add("CpE");
            comboBoxCourses.Items.Add("EcE");
            comboBoxCourses.Items.Add("CE");
            comboBoxCourses.Items.Add("Archi");
        }

        private void Example4_Load(object sender, EventArgs e)
        {
            comboBoxCourses.SelectedIndex = 0;

            labelYouSelected.Text = "";

            comboBoxCourses.SelectedIndexChanged += comboBoxCourses_SelectedIndexChanged;
                
            
        }

        private void comboBoxCourses_SelectedIndexChanged(object send,  EventArgs e)
        {
            string selectedItem = comboBoxCourses.SelectedItem.ToString();

            switch (selectedItem)
            {
                case "None": 
                    labelYouSelected.Text = "You selected None";
                    textBox1.Text = "None";
                    break;
                case "CpE":
                    labelYouSelected.Text = "You selected CpE";
                    textBox1.Text = "Computer Engineering";
                    break;
                case "EcE":
                    labelYouSelected.Text = "You selected EcE";
                    textBox1.Text = "Electronics and Communication Engineering";
                    break;
                case "CE":
                    labelYouSelected.Text = "You selected CE";
                    textBox1.Text = "Civil Engineering";
                    break;
                case "Archi":
                    labelYouSelected.Text = "You selected Archi";
                    textBox1.Text = "Architecture";
                    break;
                default:
                    MessageBox.Show("Please put Valid values!");
                    break;
            }
            labelYouSelected.Text = selectedItem.ToString();
        }
    }
}
