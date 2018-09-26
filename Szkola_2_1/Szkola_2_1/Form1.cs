using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Szkola_2_1
{
    public partial class Form1 : Form
    {

  

        public Form1()
        {
            InitializeComponent();
        }

        int x = 6;

        private void bROLL_Click(object sender, EventArgs e)
        {
            
            if (x == 6)
            {
                Random r = new Random();
                int iRnd = new int();
                iRnd = r.Next(0, 6);

                if (iRnd == 0)
                    showdice.Image = pbdice1.Image;
                else if (iRnd == 1)
                    showdice.Image = pbdice2.Image;
                else if (iRnd == 2)
                    showdice.Image = pbdice3.Image;
                else if (iRnd == 3)
                    showdice.Image = pbdice4.Image;
                else if (iRnd == 4)
                    showdice.Image = pbdice5.Image;
                else if (iRnd == 5)
                    showdice.Image = pbdice6.Image;
            }
            else if (x == 4)
            {
                Random r = new Random();
                int iRnd = new int();
                iRnd = r.Next(0, 4);

                if (iRnd == 0)
                    showdice.Image = pbdice4_1.Image;
                else if (iRnd == 1)
                    showdice.Image = pbdice4_2.Image;
                else if (iRnd == 2)
                    showdice.Image = pbdice4_3.Image;
                else if (iRnd == 3)
                    showdice.Image = pbdice4_4.Image;
               
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                x = 6;
            }
            else if (radioButton2.Checked == true)
            {
                x = 4;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are u sure u want to quit the Dice app?", ":(", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by: Jakub Jaworski");
        }
    }
}
