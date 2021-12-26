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
    public partial class FormCek : Form
    {
        public FormCek(string kulad, int tutar)
        {
            InitializeComponent();
            label4.Text = Siparis.sepetTutar.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lblcekSirket.Text = textBox2.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            lblcekAdSoyad.Text = textBox4.Text;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            lblcekSeriNo.Text = maskedTextBox1.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox4.Text == "" || maskedTextBox1.Text =="")
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
        class Acek : Odeme
        {
            public string SirketIsmi { get; set; }
            public int SeriNo { get; set; }

            public override void Ode(double Tutar)
            {
                OdenecekTutar = Tutar;
            }
        }
        private void FormCek_Load(object sender, EventArgs e)
        {

        }
        
    }
}
