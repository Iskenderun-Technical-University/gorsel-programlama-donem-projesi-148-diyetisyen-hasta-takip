using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diyetisyen_Hasta_TKİP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {




        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void HESAPLA_Click(object sender, EventArgs e)
        {
            double boy = Convert.ToDouble(textBox4.Text);
            double kilo = Convert.ToDouble(textBox5.Text);
            double boykare = Math.Pow(boy, 2);
    
            double sonuç = kilo / boykare;

            label16.Text = sonuç.ToString();


            if (sonuç<18)
            {
                label24.Text = "ideal kilomuzun altındasınız";
            }
            else if(sonuç<25 && sonuç>18)
            {
                label24.Text = "ideal kilodasınız";
            }
            else if(sonuç < 30 && sonuç > 25)
            {
                label24.Text = "ideal kilonuzun üstündesiniz";
            }
            else if(sonuç < 35 && sonuç > 30)
            {
                label24.Text = "obezsiniz";
            }
            else if(sonuç > 35)
            {
                label24.Text = "morbid obezsiniz";
            }
            // BURADA VÜCUT KİTLE ENDEKSİNİ HESAPLADIK 

           



        }
       
        private void button3_Click(object sender, EventArgs e)
        {

        }
        
    }

        
    }