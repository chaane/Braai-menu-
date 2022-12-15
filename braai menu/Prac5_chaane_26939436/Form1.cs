using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac5_chaane_26939436
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Green;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;  
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor= System.Drawing.Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Quantitiy;
            
            Quantitiy =int.Parse( textBox1.Text);

            if ( radioButton1.Checked==true)
            {
                MessageBox.Show(textBox1.Text +" Pap and wors orders are in their way");
                return;
            }
            else if( radioButton2.Checked == true)
            {
                MessageBox.Show(textBox1.Text +" Delicious Fillet Steak with roast veggies coming up" );
                return;
            }
            else if ( radioButton3.Checked == true)
            {
                MessageBox.Show(textBox1.Text +" Of your Chicken and chips on his way");
                return;
            }
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;
        }
    }
}
