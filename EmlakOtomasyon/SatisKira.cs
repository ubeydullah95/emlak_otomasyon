using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyon
{
    public partial class SatisKira : Form
    {
        public SatisKira()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Musteriler musteri = new Musteriler();
            musteri.Show();
        }

        private void SatisKira_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'emlakDataSet13.Musteriler' table. You can move, or remove it, as needed.
            this.musterilerTableAdapter2.Fill(this.emlakDataSet13.Musteriler);
            // TODO: This line of code loads data into the 'emlakDataSet12.IptalIslemi' table. You can move, or remove it, as needed.
            this.iptalIslemiTableAdapter.Fill(this.emlakDataSet12.IptalIslemi);
            // TODO: This line of code loads data into the 'emlakDataSet6.Musteriler' table. You can move, or remove it, as needed.
            this.musterilerTableAdapter1.Fill(this.emlakDataSet6.Musteriler);
            // TODO: This line of code loads data into the 'emlakDataSet4.Musteriler' table. You can move, or remove it, as needed.
            this.musterilerTableAdapter.Fill(this.emlakDataSet4.Musteriler);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VeriTabani veri = new VeriTabani();
            veri.Satis(Convert.ToInt32(textBox4.Text), cellValue, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToInt32(textBox1.Text));
            MessageBox.Show("İşlem Gerçekleştirildi");
            Close();
            SatisKira sat = new SatisKira();
            sat.Show();
        }
        public int cellValue,cellValue2;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cellValue = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
            SatisKira sat = new SatisKira();
            sat.Show();
        }

        private void SatisKira_FormClosed(object sender, FormClosedEventArgs e)
        {
            İlanlar ilan = new İlanlar();
            ilan.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VeriTabani vt = new VeriTabani();
            vt.IslemIptal(cellValue2);
            Close();
            SatisKira sat = new SatisKira();
            sat.Show();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cellValue2 = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
        }

    }
}
