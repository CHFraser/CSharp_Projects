// ciara Fraser
// December 1, 2023
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double val1;
            double val2;
            double result;

            while (double.TryParse(txtBxValue1.Text, out val1) == false
                                                            || val1 < 0) 
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Value must be numeric and more than 0.";
                txtBxValue1.Text = "0";
                txtBxValue1.Focus();
            }

            while (double.TryParse(txtBxValue2.Text, out val2) == false
                                                          || val2 < 0)
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Value must be numeric and more than 0.";
                txtBxValue2.Text = "0";
                txtBxValue2.Focus();
            }

            result = val1 + val2;
            lblResult.Text = "Result: " + result;
            lblResult.Visible = true;
           
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            double val1;
            double val2;
            double result;

            if (double.TryParse(txtBxValue1.Text, out val1) == false
                                                            || val1 < 0)
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Value must be numeric and more than 0.";
                txtBxValue1.Text = "0";
                txtBxValue1.Focus();
            }

            else if (double.TryParse(txtBxValue2.Text, out val2) == false
                                                          || val2 < 0)
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Value must be numeric and more than 0.";
                txtBxValue2.Text = "0";
                txtBxValue2.Focus();
            }
            else
            {
                result = val1 * val2;
                lblResult.Text = "Result: " + result;
            }
            
        }

        // button reset
        private void button1_Click(object sender, EventArgs e)
        {
            txtBxValue1.Text = "0";
            txtBxValue2.Text = "0";
        }
    }
}
