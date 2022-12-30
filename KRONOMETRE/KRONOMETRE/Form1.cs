using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRONOMETRE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Value = progressBar1.Value + (1);

            label1.Text ="YÜKLENİYOR     "+"%"+ progressBar1.Value.ToString();
            if (progressBar1.Value == 50)
            {
                label1.Text = " AZ KALDI..." ;

          
            }


            if (progressBar1.Value == 75)
            {

                label1.Text = "  BİTİYOR...";
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }


        int saat = 0, dakika= 0, saniye=0;

        private void button2_Click(object sender, EventArgs e)
        {
       
            timer2.Enabled = false; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "  " + saat.ToString().PadLeft(2, '0') + "   :   " + dakika.ToString().PadLeft(2, '0') + "   :   " + saniye.ToString().PadLeft(2, '0');
            timer2.Enabled=false;   
            saat= 0;
            dakika= 0;
            saniye= 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
       
            textBox1.Text = "  "+saat.ToString().PadLeft(2,'0')+"   :   "+dakika.ToString().PadLeft(2,'0')+"   :   "+saniye.ToString().PadLeft(2, '0')   ;


             if (saniye == 60)
            {

                dakika++;
                saniye= 0;

            }

            if(dakika== 60) {
            
                saat++; 
                dakika= 0;  
            }
            if (saat == 24)
            {
                saniye = 0;
                dakika= 0;
                saniye= 0;

            }
            saniye++;  
        }
    }
}
