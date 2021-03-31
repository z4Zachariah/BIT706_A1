using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT706_A1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String Account = "Everyday";

        // info template:
        //information = "Omni 67; Interest Rate 4%; Overdraft Limit $1000; Fee $10; Balance $560.34;";

        Everyday EverydayAccount = new Everyday(100.00, 0, 0);

        Investment InvestmentAccount = new Investment(900.00, 4, 1.00);

        Omni OmniAccount = new Omni(5.00, 10, 2.00, -100.00);

        //on clicking the radio buttons, change the targeted account

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Account = "Everyday";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Account = "Investment";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Account = "Omni";

        }


        //click listener for info button
        private void InfoButton_Click(object sender, EventArgs e)
        {
            
            //depending on which account is elected, display that account's info
            switch(Account)
            {
                case "Everyday":

                    OutputBox.Items.Add(EverydayAccount.Info());

                    break;

                case "Investment":
                    OutputBox.Items.Add(InvestmentAccount.Info());
                    break;

                case "Omni":
                    OutputBox.Items.Add(OmniAccount.Info());
                    break;

                default:
                    OutputBox.Items.Add("Error");
                    break;
            }

        }// end of info button listener





        //Deposit button listener
        private void DepositButton_Click(object sender, EventArgs e)
        {
            // get the input amount
            double amount = Convert.ToDouble(AccountInput.Text);

            // if the input amount is 0 or negative, display an error, else deposit into the selected account
            if (amount <= 0)
            {
                OutputBox.Items.Add("Please Input a Valid Amount");

            }

            else
            {
                switch (Account)
                {
                    case "Everyday":
                        EverydayAccount.Deposit(amount);
                        OutputBox.Items.Add("Deposited $" + amount + " into Everyday Account");
                        AccountInput.Text = "0.00";
                        break;

                    case "Investment":
                        InvestmentAccount.Deposit(amount);
                        OutputBox.Items.Add("Deposited $" + amount + " into Investment Account");
                        AccountInput.Text = "0.00";
                        break;

                    case "Omni":
                        OmniAccount.Deposit(amount);
                        OutputBox.Items.Add("Deposited $" + amount + " into Omni Account");
                        AccountInput.Text = "0.00";
                        break;

                    default:
                        OutputBox.Items.Add("Error");
                        break;
                }
            }


        }



        //Withdrawal button listener
        private void WithdrawButton_Click(object sender, EventArgs e)
        {

            double amount = Convert.ToDouble(AccountInput.Text);

            // if the input amount is 0 or negative, display an error, else withdraw from the selected account
            if (amount <= 0)
            {
                OutputBox.Items.Add("Please Input a Valid Amount");

            }

            else
            {


                //depending on which account is elected, display that account's info
                switch (Account)
                {
                    case "Everyday":
                        EverydayAccount.Withdraw(amount);
                        OutputBox.Items.Add(EverydayAccount.Info());
                        AccountInput.Text = "0.00";


                        break;

                    case "Investment":
                        InvestmentAccount.Withdraw(amount);
                        OutputBox.Items.Add(InvestmentAccount.Info());
                        AccountInput.Text = "0.00";


                        break;

                    case "Omni":
                        OmniAccount.Withdraw(amount);
                        OutputBox.Items.Add(OmniAccount.Info());
                        AccountInput.Text = "0.00";


                        break;

                    default:
                        OutputBox.Items.Add("Error");
                        break;
                }
            }

        }



        // Button to clear the output
        private void ClearButton_Click(object sender, EventArgs e)
        {

            OutputBox.Items.Clear();

        }




        // Button to add interest to an account
        private void InterestButton_Click(object sender, EventArgs e)
        {
            //Add the calculated interest to the selected account
            switch (Account)
            {
                case "Everyday":
                    OutputBox.Items.Add("Interest Added: $" + EverydayAccount.CalcInterest());
                    EverydayAccount.AddInterest();
                    OutputBox.Items.Add(EverydayAccount.Info());
                    break;

                case "Investment":
                    OutputBox.Items.Add("Interest Added: $" + InvestmentAccount.CalcInterest());
                    InvestmentAccount.AddInterest();
                    OutputBox.Items.Add(InvestmentAccount.Info());

                    break;

                case "Omni":
                    OutputBox.Items.Add("Interest Added: $" + OmniAccount.CalcInterest());
                    OmniAccount.AddInterest();
                    OutputBox.Items.Add(OmniAccount.Info());

                    break;

                default:
                    OutputBox.Items.Add("Error");
                    break;
            }
        }



        // click listeners for buttons 






    }
}
