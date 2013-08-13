using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunWithJoeAndBob
{
    public partial class Form1 : Form
    {

        Guy joe;
        Guy bob;
        int bank = 100;

        public Form1()
        {
            InitializeComponent();
            joe = new Guy();
            bob = new Guy();
            joe.Name = "Joe";
            joe.Cash = 50;
            bob.Name = "Bob";
            bob.Cash = 100;
            updateForm();
        }

        public void updateForm()
        {
            joesCashLabel.Text = joe.Name + " has $" + joe.Cash;
            bobsCashLabel.Text = bob.Name + " has $" + bob.Cash;
            bankCashLabel.Text = "The bank has $" + bank;
            joeGivesToBob.Text = "Joe gives $10 to Bob.";
            bobGivesToJoe.Text = "Bob gives $5 to Joe.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.receiveCash(10);
                updateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.giveCash(5);
            updateForm();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            bob.receiveCash(joe.giveCash(10));
            updateForm();
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            joe.receiveCash(bob.giveCash(5));
            updateForm();
        }


    }
}
