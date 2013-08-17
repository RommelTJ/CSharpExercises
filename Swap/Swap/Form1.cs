using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swap
{
    public partial class Form1 : Form
    {
        Elephant lucinda;
        Elephant lloyd;

        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant temp = new Elephant();
            temp = lucinda;
            lucinda = lloyd;
            lloyd = temp;
            MessageBox.Show("Objects Swapped.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.whoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.whoAmI();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lloyd.TellMe("Hi", lucinda);
            lloyd = lucinda;
            lloyd.EarSize = 4321;
            lloyd.whoAmI();
        }
    }
}
