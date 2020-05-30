using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace EmlakOtomasyon
{
    public partial class Emlak : Form
    {
        public Emlak()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            İlanlar ilan = new İlanlar();
            ilan.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Musteriler musteri = new Musteriler();
            musteri.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Raporlar rapor=new Raporlar();
            rapor.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0,1);
        }

        private void Emlak_Load(object sender, EventArgs e)
        {
            label1.Text = "                                                                                            EMLAK TAKİP SİSTEMİ";
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
