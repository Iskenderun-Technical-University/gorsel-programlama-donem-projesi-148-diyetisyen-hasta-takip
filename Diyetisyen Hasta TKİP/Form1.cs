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
        public static string adsoyad = "";
        public static double boyy  = 0;
        public static int kiloy = 0;
        public static string cinsiyet = "";
        public static double vkii = 0.0;
        public static double kalori1 = 0.0;
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


            adsoyad = textBox3.Text;
            boyy = Convert.ToDouble(textBox4.Text);
            kiloy = Convert.ToInt32(textBox5.Text);
            if (radioButton1.Checked)
            {
                cinsiyet = "kadin";
            }
            else if (radioButton2.Checked)
            {
                cinsiyet = "erkek";
            }

            vkii = Convert.ToDouble(label16.Text);
           

        }
       
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = 1; // 60 dan küçük erkek sabiti
            double b = 0.8; // 60 dan büyük erkek sabiti 
            double c = 0.95; // 60 dan küçük kadın sabiti 
            double d = 0.8; //60 dan büyük kadın sabiti 
            double bmh;
            double yaş=Convert.ToDouble(textBox6.Text);
            double kilo = Convert.ToDouble(textBox5.Text);
            double kalori;



            if (radioButton2.Checked==true) // erkek için 
            {
             if(yaş<60) // 60 yaşından küçük erkek
                {
                    bmh = a * kilo * 24; // bazal metabolizma hızı hesaplama 
                    if(radioButton3.Checked==true) // hafif hareket için
                    {
                        kalori=bmh*1.6;
                        // bazal metabolizma hızı ve sabit değişken çarpılır ve günlük alınması
                        // gereken kalori bulunur.
                        label19.Text = kalori.ToString();


                    }
                    else if(radioButton4.Checked==true) // orta hareket için
                    {
                        kalori = bmh * 1.7;
                        label19.Text=kalori.ToString();
                        
                    }
                    else if(radioButton5.Checked==true) // yüksek hareket için 
                    {
                        kalori = bmh * 2.1;
                        label19.Text = kalori.ToString();

                    }
                }
                else if(yaş>=60) // 60 yaşında ve yaşından büyük için
                {
                    bmh = b * kilo*24;

                    if (radioButton3.Checked == true)
                    {
                        kalori = bmh * 1.6;
                        label19.Text = kalori.ToString();


                    }
                    else if (radioButton4.Checked == true)
                    {
                        kalori = bmh * 1.7;
                        label19.Text = kalori.ToString();

                    }
                    else if (radioButton5.Checked == true)
                    {
                        kalori = bmh * 2.1;
                        label19.Text = kalori.ToString();

                    }
                }
            }
            else if(radioButton1.Checked==true) // kadın için 
            {
                if(yaş<60) // 60 yaşından küçük kadın için 
                {
                    bmh = c * kilo * 24;
                    // sabit değerlerle kilo çarpılır bazal metabolizma hızı bulunur 
                    if(radioButton3.Checked == true)
                    {
                        kalori = bmh * 1.5;
                        // sabit değişkenle bmh çarpılır.
                        label19.Text=kalori.ToString(); 
                    }
                    else if(radioButton4.Checked == true)
                    {
                        kalori=bmh*1.6;
                        // sabit değişkenle bmh çarpılır.
                        label19.Text=kalori.ToString(); 

                    }
                    else if(radioButton5.Checked==true)
                    {
                        kalori = bmh * 1.9;
                        // sabit değişkenle bmh çarpılır.
                        label19.Text=kalori.ToString();


                    }
                }
                else if(yaş>=60) // 60 yaşında ve büyük için kadın 
                {
                    bmh = d * kilo * 24;
                    // sabit değerlerle kilo çarpılır bazal metabolizma hızı bulunur 
                    if (radioButton3.Checked == true)
                    {
                        
                        kalori = bmh * 1.5;
                        // sabit değişkenle bmh çarpılır.
                        label19.Text = kalori.ToString();
                    }
                    else if (radioButton4.Checked == true)
                    {
                        kalori = bmh * 1.6;
                        // sabit değişkenle bmh çarpılır.
                        label19.Text = kalori.ToString();

                    }
                    else if (radioButton5.Checked == true)
                    {
                        kalori = bmh * 1.9;
                        // sabit değişkenle bmh çarpılır.
                        label19.Text = kalori.ToString();


                    }

                }
            }
            kalori1 = Convert.ToDouble(label19.Text);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }

        
    }