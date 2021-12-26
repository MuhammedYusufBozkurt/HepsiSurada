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

namespace HepsiSurada
{
    public partial class FormKredi : Form
    {
        public FormKredi()
        {
            InitializeComponent();
            lbl_odeme.Text = Siparis.sepetTutar.ToString()+" TL";
        }

        class Kredi_Karti : Odeme
        {
            public decimal KartNo { get; set; }
            public DateTime SonKulTarihi { get; set; }
            public int CVV { get; set; }
            public static int ay { get; set; }
            public double toplam = 0;

            public override void Ode(double Tutar)
            {
                toplam = Tutar;
                switch (ay)
                {
                    case 1:
                        toplam *= 1;
                        break;

                    case 3:
                        toplam *= 1.1;
                        break;

                    case 6:
                        toplam *= 1.2;
                        break;

                    case 12:
                        toplam *= 1.3;       
                        break;

                    default:
                        MessageBox.Show("Taksit Seçilmedi");
                        break;
                }
            }
        }
        //TAKSİTLENDİRME
        private void radioButton1_CheckedChanged(object sender, EventArgs e)//TEK
        {
            Kredi_Karti.ay = 1;
            Kredi_Karti k = new Kredi_Karti();
            k.Ode(Odeme.OdenecekTutar);
            Siparis.sepetTutar = k.toplam;
            lbl_odeme.Text = k.toplam.ToString()+ " TL";
           
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)//3 TAKSİT
        {
            Kredi_Karti.ay = 3;
            Kredi_Karti k = new Kredi_Karti();
            k.Ode(Odeme.OdenecekTutar);
            Siparis.sepetTutar = k.toplam;
            lbl_odeme.Text = Math.Round(k.toplam).ToString() + " TL";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)//6 TAKSİT
        {
            Kredi_Karti.ay = 6;
            Kredi_Karti k = new Kredi_Karti();
            k.Ode(Odeme.OdenecekTutar);
            Siparis.sepetTutar = k.toplam;
            lbl_odeme.Text = Math.Round(k.toplam).ToString() + " TL";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)//12 TAKSİT
        {
            Kredi_Karti.ay = 12;
            Kredi_Karti k = new Kredi_Karti();
            k.Ode(Odeme.OdenecekTutar);
            Siparis.sepetTutar = k.toplam;
            lbl_odeme.Text = Math.Round(k.toplam).ToString() + " TL";
        }


        //KREDİ KARTI BİLGİLERİ
        private void btnKredi_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || maskedTextBox1.Text == "" || comboBox1.Text == "" || maskedTextBox4.Text == "")
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
        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            lblkrediAdSoyad.Text = textBox4.Text;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblkrediTarih.Text = comboBox1.Text + "/" + comboBox2.Text;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblkrediTarih.Text = comboBox1.Text + "/" + comboBox2.Text;
        }
        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
            lblkredino.Text = maskedTextBox1.Text;
        }
        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
    
   
}
