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
    public partial class hastalar : Form
    {
        public hastalar()
        {
            InitializeComponent();
        }

        private void hastalar_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Form1.adsoyad, Form1.boyy, Form1.kiloy, Form1.cinsiyet, Form1.vkii, Form1.kalori1);
        }
    }
}
