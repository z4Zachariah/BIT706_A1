using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A1
{
    public abstract class Account
    {
        // Static ID variable to ensure Unique Id creation 
        protected static int nextID = 1;
        //Class instance variables
        protected int id;
        protected String type;
        protected double balance;
        protected double interest;
        protected double fee;
        protected String information;
        protected String history;


        // Constructors
        public Account()
        {
            id = nextID;
            nextID++;
        }

        // I didn't need all of these constructors, but I included them for posterity and to illustrate inheritance progression

        public Account(double openBalance) : this()
        {

            balance = openBalance;

        }

        public Account(double openBalance, double intRate) : this(openBalance)
        {

            interest = intRate;

        }

        public Account(double openBalance, double intRate, double fees) : this(openBalance, intRate)
        {

            fee = fees;

        }


        //Methods

        //Deposit an amount
        public void Deposit(double amount)
        {
            
            balance = balance + amount;
            history = "Last Transaction: \n Deposited: $" + amount; 
        }


        //Withdraw an amount
        public virtual void Withdraw(double amount)
        {
            // if the amount trying to be taken is greater than the balance, apply the fee else withdraw the amount
            if(amount > balance)
            {
                ApplyFee();
            }
            else
            {
                balance = balance - amount;

            }

            

        }

        //Add the interest to the account
        public void AddInterest()
        {
            balance = balance + CalcInterest();
        }

        
        //Calculate the value of interest to be added to an account
        public double CalcInterest()
        {
            double percent = interest / 100;

            return balance * percent;

        }

        //Apply a fee
        protected void ApplyFee()
        {
            balance = balance - fee;
            history = "Failed Transaction, Fee applied";


        }

        //Return the relevant info for an account
        public virtual String Info()
        {

            information = Type + " " + Id + "; " + "Interest Rate: " + Interest + "%; " + "Fee $" + Fee + "; " + "Balance " +"$"+ Balance; 

            return Information + " \r" + History;
        }


        // Getters and Setters using Properties

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public double Interest
        {
            get { return interest; }
            set { interest = value; }
        }

        public double Fee
        {
            get { return fee; }
            set { fee = value; }
        }

        public String Information
        {
            get { return information; }
            set { information = value; }
        }

        public String History
        {
            get { return history; }
            set { history = value; }
        }




    }// end of Account Superclass





    //Everyday Account Class
    public class Everyday : Account
    {
      
        //Use the constructor to set the type
        public Everyday(double openBalance, double intRate, double fees) : base(openBalance, intRate, fees)
        {
            type = "Everyday";

        }

    }// end of everyday account class




    //Investment Account Class

    public class Investment : Account
    {

        //Use the constructor to set the type
        public Investment(double openBalance, double intRate, double fees) : base(openBalance, intRate, fees)
        {
            type = "Investment";


        }


    }// end of investment account class



    //Omni Account Class

    public class Omni : Account
    {
        //institute overdraft limit
        private double overdraft;


        // new constructor with overdraft and setting type
        public Omni(double openBalance, double intRate, double Fees, double overdraftLimit) : base(openBalance, intRate, Fees)
        {
            type = "Omni";

            overdraft = overdraftLimit;

        }



        //override withdrawal to account for overdraft
        // If the withdrawal goes over the overdraft, apply the fee
        public override void Withdraw(double amount)
        {
            if ((balance-amount) < overdraft)
            {
                ApplyFee();
            }
            else
            {
                balance = balance - amount;

            }


        }// end of withdrawal method





        public override String Info()
        {
            //information = "Omni 67; Interest Rate 4%; Overdraft Limit $100; Fee $10; Balance $560.34;";

            information = Type + " " + Id + "; " + "Interest Rate: " + Interest + "%; " + "Overdraft Limit: $"+ overdraft + ";  Fee $" + Fee + "; " + "Balance " + "$" + Balance;

            return information + " " + history;
        }// end of info method


    }// end of Omni Account Class







}// end of namespace

