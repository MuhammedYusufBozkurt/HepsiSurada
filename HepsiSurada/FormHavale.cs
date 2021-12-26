using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HepsiSurada
{
    public partial class FormHavale : Form
    {
        public FormHavale(string kulad, int tutar)
        {
            InitializeComponent();
            lbl_odeme.Text = Siparis.sepetTutar.ToString()+ " TL";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CVV_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            lblbankNo.Text = maskedTextBox1.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            lblbankAdSoyad.Text = textBox4.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblbankTarih.Text = comboBox1.Text + "/" + comboBox2.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblbankTarih.Text = comboBox1.Text + "/" + comboBox2.Text;
        }

        private void lblbankNo_Click(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
        class Nakit : Odeme
        {
            public decimal KartNo2 { get; set; }
            public DateTime SonKulTarihi2 { get; set; }
            public int CVV2 { get; set; }

            public override void Ode(double Tutar)
            {
                OdenecekTutar = Tutar * 0.9;
            }
        }

        private void btnHavale_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "" || textBox4.Text == "" || comboBox1.Text == "" || maskedTextBox4.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Boş alanları doldurunuz");
            }
            else
            {
                Siparis s = new Siparis();
                MessageBox.Show(s.SiparisEkle().ToString());
                this.Hide();
            }
        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
