using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoiseAnnoys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            String Poem = "";
            while(x<4) {
                Poem = Poem + "a";
                if(x<1){
                    Poem = Poem + " ";
                }
                Poem = Poem + "n";
                if(x>1){
                    Poem = Poem + " oyster";
                    x = x + 2;
                }
                if(x==1){
                    Poem = Poem + "noys ";
                }
                if(x<1){
                    Poem = Poem + "oise ";
                }
                x=x+1;
            }
            MessageBox.Show(Poem);
        }
    }
}
