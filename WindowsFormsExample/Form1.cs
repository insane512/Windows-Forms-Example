using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

            
            lableOutput1.Text = firstNameTxtBox.Text;
            labelOutput2.Text = lastNameTxBox.Text;
            labelOutput3.Text = addressTxBox.Text;
            labelOutput4.Text = emailTxBox.Text;
            labelOutput5.Text = phoneTxBox.Text;




        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {

            firstNameTxtBox.Clear();
            lastNameTxBox.Clear();
            addressTxBox.Clear();
            emailTxBox.Clear();
            phoneTxBox.Clear();
           


        }
    }
}
