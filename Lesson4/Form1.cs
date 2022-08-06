using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int dakika = 0, saat = 0, saniye = 0;
        private void tick(object sender, EventArgs e)
        {
            saniye++;
            label1.Text = saniye.ToString();
            if (saniye>0 && saniye%60==0)
            {
                dakika++;
                label2.Text = dakika.ToString();
                if (dakika>0 && dakika%60==0)
                {
                    saat++;
                    label3.Text = saat.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 5;
              
            }
            else
            {
                MessageBox.Show("Error");
                Close();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
            {
                progressBar1.Value = progressBar1.Value - 5;

            }
            else
            {
                MessageBox.Show("Error");
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (true)
            {
                progressBar1.Value = progressBar1.Value + 1;

                if (progressBar1.Value==100)
                {
                    break;

                }
            }
        }

        private void tick2(object sender, EventArgs e)
        {
          

        }

        private void tick3(object sender, EventArgs e)
        {

        }
    }
}
