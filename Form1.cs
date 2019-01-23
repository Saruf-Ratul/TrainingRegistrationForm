using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingRegistrationForm
{
    public partial class Form1 : Form
    {
        string _nameComboBox = String.Empty;
        string _courseComboBox = "";
        string _pricetextBox1 = "";
        string _pricetextBox2 = "";
        string _durationComboBox = "";
        private string _number = "";



        public Form1()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            _nameComboBox = nameComboBox.Text;
            _courseComboBox = courseComboBox.Text;
            _durationComboBox = durationComboBox.Text;
            _number = numberTextBox.Text;


            MessageBox.Show("Successful Registration");

        }

        private void pricetextBox1_TextChanged(object sender, EventArgs e)
        {

            //MessageBox.Show();
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Organization Name is : " + nameComboBox.Text 
                + "\n Course Name is : " + courseComboBox.Text
                + "\n Duration of Course is : "+ durationComboBox.Text
                + "\n Number of Seat is : "+ numberTextBox.Text
                
              
                );



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
