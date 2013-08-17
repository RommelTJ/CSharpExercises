using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SloppyJoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MenuMaker maker = new MenuMaker() { Randomizer = new Random() };
            label1.Text = maker.GetMenuItem();
            label2.Text = maker.GetMenuItem();
            label3.Text = maker.GetMenuItem();
            label4.Text = maker.GetMenuItem();
            label4.Text = maker.GetMenuItem();
            label5.Text = maker.GetMenuItem();
            label6.Text = maker.GetMenuItem();
        }
    }
}
