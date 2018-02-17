using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    
    public partial class frmAssignment3 : Form
    {
        int LAButton; int FIButton;

        public frmAssignment3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLoanAmount.Select();
            cmbYears.SelectedIndex = 5;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tpCalculator_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculatePayment_Click(object sender, EventArgs e)
        {
            double loanAmount = 0.0;
            double interestRate = 0.0;
            int years = 0;
            double paymentTotal = 0.0;
            double interestPaid = 0.0;
            double monthlyPayment = 0.0;
            int numberOfPayments = 0;
            double check1;
            double check2;

            loanAmount = Convert.ToDouble(txtLoanAmount.Text);
            interestRate = Convert.ToDouble(txtFixedInterestRate.Text);
            years = Convert.ToInt16(cmbYears.Text);

           /* if (check1==Convert.ToDouble(txtLoanAmount) & check2==Convert.ToDouble(txtFixedInterestRate))
            {
                btnCalculatePayment.Enabled = true;
            }
            else
            {
                btnCalculatePayment.Enabled = false;
            }
        */

            monthlyPayment = calcPayment(loanAmount, years, interestRate);
            numberOfPayments = years * 12;
            paymentTotal = numberOfPayments * monthlyPayment;
            interestPaid = paymentTotal - loanAmount;

            txtMonthlyPayment.Text = string.Format("{0:c}", monthlyPayment);
            txtNumberOfPayments.Text = Convert.ToString(numberOfPayments);
            txtPaymentTotal.Text = string.Format("{0:c}", paymentTotal);
            txtInterestPaid.Text = string.Format("{0:c}", interestPaid);
            
        }

        public double calcPayment(double presentValue, double financingPeriod, double interestRatePerYear)
        {
            double a, b, x;
            double monthlyPayment;
            a = (1 + interestRatePerYear / 1200);
            b = financingPeriod * 12;
            x = Math.Pow(a, b);
            x = 1 / x;
            x = 1 - x;
            monthlyPayment = (presentValue) * (interestRatePerYear / 1200) / x;
            return (monthlyPayment);
        }

        private void txtLoanAmount_Validating(object sender, CancelEventArgs e)
        {
            double check1; double check2;
            if (!double.TryParse(txtLoanAmount.Text, out check1))
            {
                btnCalculatePayment.Enabled = false;
                return;

            }
            else
            {
                if (double.TryParse(txtFixedInterestRate.Text, out check2))
                {
                    btnCalculatePayment.Enabled = true;
                    return;

                }
                else
                {
                    btnCalculatePayment.Enabled= false;
                    return;
                }
                return;
            }
                
                /*double temp;

            try
            {
                temp = Convert.ToDouble(txtLoanAmount.Text);
                errorProvider1.SetError(txtLoanAmount, "");
                
            }

            catch
            {
                errorProvider1.SetError(txtLoanAmount, "Invalid Amount");
            }*/




        }

        private void txtFixedInterestRate_Validated(object sender, EventArgs e)
        { 
            /*double temp;
            try
            {
                temp = Convert.ToDouble(txtFixedInterestRate.Text);
                errorProvider1.SetError(txtFixedInterestRate, "");
}
            catch
            {
                errorProvider1.SetError(txtFixedInterestRate, "Invalid Amount");
            }*/
            

            
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pnlColor.BackColor = colorDialog1.Color;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            lblFont.Font = fontDialog1.Font;
        }
    }
}
