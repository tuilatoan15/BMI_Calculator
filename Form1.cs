using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int weight = (int)nmkg.Value;
            int height = (int)nmCm.Value;

            double result = (double)weight / Math.Pow((double)height / 100, 2);
            double lastResult = Math.Round(result, 2);

            if (Double.IsNaN(lastResult))
            {
                lastResult = 0.00;
            }

            lblResult.Text = "Your BMI is " + lastResult;

            if (lastResult < 18.5)
            {
                lblNotice.Text = "Your weight is UNDERWEIGHT";
            }
            else if (lastResult >= 18.5 &&  lastResult <= 24.9)
            {
                lblNotice.Text = "Your weight is NORMAL";
            }
            else if (lastResult >= 25 && lastResult <= 29.9)
            {
                lblNotice.Text = "Your weight is OVERWEIGHT";
            } 
            else if (lastResult >= 30 && lastResult <= 34.9)
            {
                lblNotice.Text = "Your weight is OBESE";
            }
            else if (lastResult >= 35)
            {
                lblNotice.Text = "Your weight is EXTREMELY OBESE";
            }
            else
            {
                lblNotice.Text = "Your weight is ...";
            }

        }
    }
}
