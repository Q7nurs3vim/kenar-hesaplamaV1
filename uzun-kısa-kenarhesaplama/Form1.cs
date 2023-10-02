using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uzun_kısa_kenarhesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kenar1, kenar2, alan, cevre;
            kenar1 = Convert.ToInt32(txtKenar1.Text);
            kenar2 = Convert.ToInt32(txtKenar2.Text);
            alan = kenar1 + kenar2;
            cevre = kenar1 * 2 + kenar2 * 2;
            lblalan.Text ="DİKDÖRTGENİN ALANI :" +alan.ToString();
            lblçevre.Text="DİKDÖRTGENİN ÇEVRESİ :"+cevre.ToString();
        }
    }
}
