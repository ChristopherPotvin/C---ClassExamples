using BankingData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 // Better to overvalidate the project than undervalidate
{
    public partial class Form1 : Form
    {
        Account acct;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create an account with an opening balance of $500
            acct = new Account(500);
            // Display current balance
            txtBalance.Text = acct.Balance.ToString("c");
        }

        // User deposits amount 
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            // Get the amount of the deposit
            decimal amount = Convert.ToDecimal(txtAmount.Text);
            decimal oldBalance = acct.Balance;

            // Call the deposit method from account
            acct.Deposit(amount);

            // Display the feedback
            if (oldBalance == acct.Balance)
            {
                MessageBox.Show("Deposit amount cannot be negative");
                txtAmount.SelectAll();
                txtAmount.Focus();
            }
            else // Successful deposit
            {
                txtBalance.Text = acct.Balance.ToString("c");
            }    
        }

        // User withdraws money
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            // Get the amount of the deposit
            decimal amount = Convert.ToDecimal(txtAmount.Text);
            decimal oldBalance = acct.Balance;
            bool success;

            // Call the withdraw method from account

            success = acct.Withdraw(amount); // success from the reference unit test BankingData

            // Display the feedback to the user
            if (success)
            {
                txtBalance.Text = acct.Balance.ToString("c");
            }

            else // Not a successful withdrawal
            {
                if (amount <= 0)
                {

                    MessageBox.Show("Withdraw amount should be positive");
                    txtAmount.SelectAll();
                    txtAmount.Focus();
                }

                else // Not sufficient amount 

                {
                    MessageBox.Show("You can withdraw not more than " + acct.Balance.ToString("c"));
                    txtAmount.SelectAll();
                    txtAmount.Focus();
                }
                
            }
        }
    }
}
