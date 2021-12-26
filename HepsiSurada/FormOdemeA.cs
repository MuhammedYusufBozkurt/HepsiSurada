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
    public partial class FormOdemeA : Form
    {
        string kullanici_ad;
        int toplam_tutar;
        public FormOdemeA()
        {
            InitializeComponent();
            Odeme.OdenecekTutar = Siparis.sepetTutar;
            label2.Text = Siparis.sepetTutar.ToString()+ " TL";
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormKredi formKredi = new FormKredi();
            this.Hide();
            formKredi.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHavale formHavale = new FormHavale(kullanici_ad, toplam_tutar);
            this.Hide();
            formHavale.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCek formCek = new FormCek(kullanici_ad, toplam_tutar);
            this.Hide();
            formCek.ShowDialog();
        }

        private void FormOdemeA_Load(object sender, EventArgs e)
        {

        }
        
        
        
        
    }
}
