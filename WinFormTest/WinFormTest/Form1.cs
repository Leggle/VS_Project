using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest
{
    public partial class Form1 : Form
    {

        Account ac = new Account();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender == Create)
            {
                ac.createAccount(Int32.Parse(ID.Text), AName.Text, Double.Parse(Balance.Text));
                MessageBox.Show("Account created!" + Environment.NewLine + "ID: "
                +ac.Id + Environment.NewLine + "Name: " +ac.AName
                + Environment.NewLine + "Balance: " + ac.Balance);
            }

            if(sender == Destroy)
            {
                Account.destroyAccount(ac);
                MessageBox.Show("Account destroyed!");
            }

            if(sender == Deposit)
            {
                ac.deposit(Double.Parse(textBox4.Text));
                MessageBox.Show("Account created!" + Environment.NewLine + "ID: "
                + ac.Id + Environment.NewLine + "Name: " + ac.AName
                + Environment.NewLine + "Balance: " + ac.Balance);
            }

            if(sender == SetMB)
            {
                ac.setMinBalance(Double.Parse(textBox5.Text));
                MessageBox.Show("Set minBalance successfully!");
            }

            if(sender == GetMB)
            {
                textBox6.Text = ac.MinBalance + "";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    public class Account
    {
        private int id;
        private string name;
        private double balance;
        private double minBalance;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string AName
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        public double MinBalance
        {
            get
            {
                return minBalance;
            }

            set
            {
                minBalance = value;
            }
        }

        public void createAccount(int _id, string _name, double _balance)
        {
            Id = _id;
            AName = _name;
            Balance = _balance;
        }

        public static void destroyAccount(Account account)
        {
            account = null;
        }

        public void deposit(double deposit)
        {
            Balance += deposit;
        }

        public void setMinBalance(double minBalance)
        {
            MinBalance = minBalance;
        }
    }
}
