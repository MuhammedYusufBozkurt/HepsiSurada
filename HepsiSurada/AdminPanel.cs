using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HepsiSurada
{
    public partial class AdminPanel : Form
    {
        //VERİTABANI BAĞLANTISI
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-68V49NQ;Initial Catalog=HepsiSurada;Integrated Security=True");

        public AdminPanel()
        {
            InitializeComponent();
        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            UrunlerListele();
            KullaniciListele();
            SiparisListele();
        }
        public void Temizle()
        {
            txt_uad.Text = "";
            combo_kategori.SelectedIndex = 0;
            txt_ustok.Text = "";
            txt_ufiyat.Text = "";
            txt_uagirlik.Text = "";
            txt_uaciklama.Text = "";
        }

        //ÜRÜNLER İLE İLGİLİ KODLAR
        public void UrunlerListele()//Veritabanından ürün verilerini listeliyoruz.
        {
            Urun urun = new Urun();
            data_urun.DataSource = urun.Listele();

            data_urun.Columns[0].HeaderText = "ID";
            data_urun.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data_urun.Columns[0].Width = 30;

            data_urun.Columns[1].HeaderText = "AD";
            data_urun.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            data_urun.Columns[2].HeaderText = "KATEGORİ";
            data_urun.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            data_urun.Columns[3].HeaderText = "AÇIKLAMA";
            data_urun.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            data_urun.Columns[4].HeaderText = "STOK";
            data_urun.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data_urun.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            data_urun.Columns[5].HeaderText = "FİYAT";
            data_urun.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            data_urun.Columns[6].HeaderText = "AĞIRLIK";
            data_urun.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public void UrunSil(int id)
        {
            Urun u = new Urun();
            if(u.Sil(id) == true)//return edilen veriyi durum değişkenine atadık
            {
                MessageBox.Show("İşlem başarılı.");
            }
            else
            {
                MessageBox.Show("HATA");
            }
            UrunlerListele();
        }
        private void data_urun_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)//Datagridview da seçili olanı kullanıyoruz.
        {
            string id, ad, kategori, aciklama, stok, fiyat, agirlik;

            id = data_urun.CurrentRow.Cells[0].Value.ToString();
            ad = data_urun.CurrentRow.Cells[1].Value.ToString();
            kategori = data_urun.CurrentRow.Cells[2].Value.ToString();
            aciklama = data_urun.CurrentRow.Cells[3].Value.ToString();
            stok = data_urun.CurrentRow.Cells[4].Value.ToString();
            fiyat = data_urun.CurrentRow.Cells[5].Value.ToString();
            agirlik = data_urun.CurrentRow.Cells[6].Value.ToString();

            txt_uid.Text = id.Trim();
            txt_uad.Text = ad.Trim();

            int index = combo_kategori.FindString(kategori);
            combo_kategori.SelectedIndex = index;

            txt_uaciklama.Text = aciklama.Trim();
            txt_ustok.Text = stok.Trim();
            txt_ufiyat.Text = fiyat.Trim();
            txt_uagirlik.Text = agirlik.Trim();
        }
        private void btn_uyeni_Click(object sender, EventArgs e)
        {
            string ad, kategori, aciklama;
            float fiyat, agirlik;
            int stok;

            string durum;
            if (combo_kategori.SelectedIndex == -1)
            {
                errorProvider1.SetError(combo_kategori, "Lütfen kategori belirtin.");
            }

            ad = txt_uad.Text;
            kategori = combo_kategori.SelectedItem.ToString();
            aciklama = txt_uaciklama.Text;
            stok = Convert.ToInt32(txt_ustok.Text);
            fiyat = Convert.ToSingle(txt_ufiyat.Text);
            agirlik = Convert.ToInt32(txt_uagirlik.Text);


            Urun ekle = new Urun();
            ekle.Ad = ad;
            ekle.Kategori = kategori;
            ekle.Aciklama = aciklama;
            ekle.Stok = stok;
            ekle.Fiyat = fiyat;
            ekle.Agirlik = agirlik;

            Urun u = new Urun();
            durum = u.Ekle(ekle);//Ekle metodundan gelen return değerini durum değişkenine atıyoruz
            MessageBox.Show(durum);
            UrunlerListele();
            Temizle();
        }
        private void btn_usil_Click(object sender, EventArgs e)
        {
            int id;
            if (txt_uid.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_uid, "Lütfen bir ürün seçiniz");
            }
            else
            {
                id = Convert.ToInt32(txt_uid.Text);
                UrunSil(id);
                errorProvider1.SetError(txt_uid, "");
            }
        }
        private void btn_uguncelle_Click(object sender, EventArgs e)
        {
           if(combo_kategori.SelectedIndex != -1)
            { 
            Urun u = new Urun();
            int id = int.Parse(txt_uid.Text);
            Urun eskiUrun = new Urun();
            eskiUrun = (Urun)data_urun.CurrentRow.DataBoundItem;

            Urun yeniUrun = new Urun();
            yeniUrun.Ad = txt_uad.Text;
            yeniUrun.Kategori = combo_kategori.SelectedItem.ToString();
            yeniUrun.Aciklama = txt_uaciklama.Text;
            yeniUrun.Stok = int.Parse(txt_ustok.Text);
            yeniUrun.Fiyat = Convert.ToSingle(txt_ufiyat.Text);
            yeniUrun.Agirlik = Convert.ToSingle(txt_uagirlik.Text);

            if(u.Guncelle(id, eskiUrun, yeniUrun) == true)
            {
                MessageBox.Show("İşlem başarılı!");
            }
            UrunlerListele();
            }
            else
            {
                MessageBox.Show("KATEGORİ BELİRTİNİZ");
            }
        }
        //*********************************************************

        //KULLANICILAR İLE İLGİLİ KODLAR
        public void KullaniciListele()//Veritabanından kullanıcı verilerini listeliyoruz.
        {
            Kullanici kul = new Kullanici();

            data_kullanici.DataSource = kul.Listele();

        }
        private void data_kullanici_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)//Datagridview da seçili olanı kullanıyoruz.
        {
            string id, ad, soyad, kulad, eposta, telefon, adres;

            id = data_kullanici.CurrentRow.Cells[0].Value.ToString();
            ad = data_kullanici.CurrentRow.Cells[1].Value.ToString();
            soyad = data_kullanici.CurrentRow.Cells[2].Value.ToString();
            kulad = data_kullanici.CurrentRow.Cells[3].Value.ToString();
            eposta = data_kullanici.CurrentRow.Cells[4].Value.ToString();
            telefon = data_kullanici.CurrentRow.Cells[5].Value.ToString();
            adres = data_kullanici.CurrentRow.Cells[6].Value.ToString();

            txt_kid.Text = id.Trim();
            txt_kad.Text = ad.Trim();
            txt_ksoyad.Text = soyad.Trim();
            txt_kullanici.Text = kulad.Trim();
            txt_keposta.Text = eposta.Trim();
            txt_ktelefon.Text = telefon.Trim();
            txt_kadres.Text = adres.Trim();

        }
        private void btn_ksil_Click(object sender, EventArgs e)
        {
            Kullanici k = new Kullanici();
            int id;
            id = int.Parse(txt_kid.Text.Trim());
            if(id != null)
            {
                if(k.silKullanici(id) == true)
                {
                    MessageBox.Show("İşlem başarılı!");
                }
                else
                {
                    MessageBox.Show("HATA");
                }
            }
            else 
            {
                MessageBox.Show("Lütfen bir kullanıcı seçiniz.");
            }
            KullaniciListele();
        }
        private void data_kullanici_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }
        //*********************************************************

        //SİPARİŞLER İLE İLGİLİ KODLAR
        public void SiparisListele()
        {
            Siparis s = new Siparis();
            data_siparis.DataSource = s.Listele();
            data_siparis.Columns["fiyat"].Visible = false;

            data_siparis.Columns[0].HeaderText = "SİPARİŞ NO";
            data_siparis.Columns[0].Width = 70;

            data_siparis.Columns[4].Width = 50;
            data_siparis.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            data_siparis.Columns[5].Width = 50;
            data_siparis.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        private void data_siparis_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_siparisno.Text = data_siparis.CurrentRow.Cells[0].Value.ToString();
        }
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string durum;
            string id = txt_siparisno.Text;
            if (id != null)
            {
                Siparis s = new Siparis();
                durum = combo_durum.SelectedItem.ToString();
                if (s.durumGuncelle(int.Parse(id), durum) == true)
                {
                    MessageBox.Show("İşlem başarılı!");
                    SiparisListele();
                }
                else
                {
                    MessageBox.Show("HATA");
                    SiparisListele();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir sipariş seçiniz!");
            }
            
        }
        //**********************************************************

        //HARF GİRİŞİ ENGELLEME
        private void txt_ustok_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txt_ufiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txt_uagirlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        //***************************************************
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lo = new Login();
            lo.ShowDialog();
        }
    }
}
