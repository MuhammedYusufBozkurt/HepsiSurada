using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HepsiSurada
{
    public partial class Alisveris : Form
    {
        private int sure;
        public Alisveris()
        {
            InitializeComponent();
            timer1.Start();
            lbl_kullanici.Text = Kullanici.kulad.ToString();
        }
        private void Alisveris_Load(object sender, EventArgs e)
        {
            UrunListele();
            //TASARIM
            metroButton1.PerformClick();
            //*******
        }
        //ANA SAYFA
        public void UrunListele()
        {
            Urun u = new Urun();
            data_urun.DataSource = u.Listele();
            data_urun.Columns[4].Visible = false;


            data_urun.Columns[0].HeaderText = "ID";
            data_urun.Columns[0].Width = 20;

            data_urun.Columns[1].HeaderText = "AD";
            data_urun.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            data_urun.Columns[2].HeaderText = "KATEGORİ";
            data_urun.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            data_urun.Columns[3].HeaderText = "AÇIKLAMA";
            data_urun.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            data_urun.Columns[5].HeaderText = "FİYAT";
            data_urun.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data_urun.Columns[5].Width = 50;
            data_urun.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            data_urun.Columns[6].HeaderText = "AĞIRLIK";
        }
        public void KategoriListele(string kat)
        {
            Urun u = new Urun();
            data_urun.DataSource = u.KategoriListele(kat);
            data_urun.Columns[4].Visible = false;
            data_urun.Columns[6].Visible = false;

            data_urun.Columns[0].HeaderText = "ID";
            data_urun.Columns[0].Width = 20;

            data_urun.Columns[1].HeaderText = "AD";
            data_urun.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            data_urun.Columns[2].HeaderText = "KATEGORİ";
            data_urun.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            data_urun.Columns[3].HeaderText = "AÇIKLAMA";
            data_urun.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            data_urun.Columns[5].HeaderText = "FİYAT";
            data_urun.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            data_urun.Columns[5].Width = 50;
            data_urun.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void combo_kategori_SelectedValueChanged(object sender, EventArgs e)//kategoriye göre listeleme sağlıyoruz
        {
            string kategori = combo_kategori.SelectedItem.ToString();
            if (kategori == "HEPSİ")
            {
                UrunListele();
            }
            else
            {
                KategoriListele(kategori);
            }
        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int urunId = int.Parse(data_urun.CurrentRow.Cells[0].Value.ToString());
            string urunAd = data_urun.CurrentRow.Cells[1].Value.ToString();
            string urunAciklama = data_urun.CurrentRow.Cells[3].Value.ToString();
            string urunFiyat = data_urun.CurrentRow.Cells[5].Value.ToString();
            string urunAgirlik = data_urun.CurrentRow.Cells[6].Value.ToString();
            bool durum = false;
            int index = 0; //SEÇİLEN SATIRIN INDEX NUMARASINI TUTACAĞIZ

            if (list_sepet.Items.Count > 0)
            {
                int i = 0;
                for (; i < list_sepet.Items.Count; i++)
                {
                    if (durum == false && list_sepet.Items[i].SubItems[0].Text == urunId.ToString() && list_sepet.Items[i].SubItems[0].Text != null)// eğer sepette aynı ürün varsa döngüden çıkartmak için durum değişkenini true yapıyoruz ve eklenenmek istenen ürünün sırasını indeks değişkrnine atıyoruz.
                    {
                        index = i;
                        durum = true;
                    }
                }
                if (durum == false)//eğer aynı ürün yoksa
                {
                    string[] row1 = { urunAd, urunAciklama, txt_miktar.Text, urunFiyat, urunAgirlik};
                    list_sepet.Items.Add(urunId.ToString()).SubItems.AddRange(row1);

                    MessageBox.Show("ÜRÜN EKLENDİ!");
                }
                else
                {
                    MessageBox.Show("Ürün zaten sepette!");
                }
            }
            else
            {
                string[] row1 = {urunAd, urunAciklama, txt_miktar.Text, urunFiyat, urunAgirlik };
                list_sepet.Items.Add(urunId.ToString()).SubItems.AddRange(row1);               

                MessageBox.Show("ÜRÜN EKLENDİ!");
            }
            lbl_adet.Text = "("+list_sepet.Items.Count.ToString()+")";
            lbl_urunadet.Text = "("+list_sepet.Items.Count.ToString()+")";
            Sepet();
            
        }
        private void btn_temizle_Click(object sender, EventArgs e)//SEPETİ BOŞALTIYORUZ!
        {
            list_sepet.Items.Clear();
            lbl_adet.Text = "(" + list_sepet.Items.Count.ToString() + ")";
            lbl_urunadet.Text = "(" + list_sepet.Items.Count.ToString() + ")";
            Sepet();
        }
        private void btn_sepetegec_Click(object sender, EventArgs e)
        {
            int urunsayisi = list_sepet.Items.Count;
            if (urunsayisi != 0)
            {
                tab_control.SelectedTab = tab_Sepet;
            }
            else
            {
                MessageBox.Show("SEPETİNİZ BOŞ!");
            }

        }
        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lo = new Login();
            lo.Show();
        }
        private void btn_profil_Click(object sender, EventArgs e)
        {
            Profil p = new Profil(Kullanici.kulid);
            p.Show();
        }
        //****************

        //SEPET
        public void Sepet()//FİYAT HESABI YAPIYOR
        {
            SiparisDetay si = new SiparisDetay();
            Urun u = new Urun();
            if (list_sepet.Items.Count != 0)
            {

                double urunToplam = 0, miktarFiyat = 0, agirlik = 0, agirlikTop = 0, vergiToplam = 0, kargoToplam = 0;
                string urunad = "";
                for (int i = 0; i < list_sepet.Items.Count; i++)
                {
                    si.Miktar = Convert.ToInt32(list_sepet.Items[i].SubItems[3].Text);
                    si.Fiyat = Convert.ToDouble(list_sepet.Items[i].SubItems[4].Text);
                    agirlik = Convert.ToSingle(list_sepet.Items[i].SubItems[5].Text) * si.Miktar;
                    urunad = list_sepet.Items[i].SubItems[1].Text;


                    miktarFiyat += si.MiktarFiyatı(si.Miktar);
                    agirlikTop += si.AgirlikHesapla(agirlik);
                    urunToplam += si.SadeceUrunler() + si.KargoHesapla(agirlikTop);
                    vergiToplam += si.VergiHesapla();
                    kargoToplam += si.KargoHesapla(agirlikTop);

                    lbl_tutar.Text = urunToplam.ToString();
                    lbl_uruntoplam.Text = miktarFiyat.ToString();
                    lbl_vergitoplam.Text = vergiToplam.ToString();
                    lbl_kargo.Text = kargoToplam.ToString(); 
                }
                Siparis.sepetTutar = urunToplam;
                Siparis.sepetUrun = urunad;
                Siparis.sepetAdet = si.Miktar;
                if(urunToplam >= 1000)
                {
                    lbl_kargo.Text = "ÜCRETSİZ";
                    lbl_kargo.ForeColor = Color.Green;
                    lbl_kargobilgi.Visible = false;
                }
                else
                {
                    lbl_kargobilgi.Text = "Sepetinize " + (1000 - urunToplam) + "TL'lik ürün daha ekleyin kargo bedava olsun.";
                    lbl_kargo.ForeColor = DefaultForeColor;
                }
            }
            else
            {
                lbl_kargo.Text = "0";
                lbl_uruntoplam.Text = "0";
                lbl_tutar.Text = "0";
                lbl_kargobilgi.Visible = false;  
            }  
        }
        int miktar;
        private void btn_artı_Click(object sender, EventArgs e)
        {
            miktar = int.Parse(txt_miktar.Text);
            miktar++;
            txt_miktar.Text = miktar.ToString();
            if (miktar>10)
            {
                txt_miktar.Text = "10";
                MessageBox.Show("En Fazla 10 Ürün Alabilirsiniz.");
                
            }
        }
        private void btn_eksi_Click(object sender, EventArgs e)
        {
            miktar = int.Parse(txt_miktar.Text);
            if (miktar > 1)
            {
                miktar--;
            }          
            txt_miktar.Text = miktar.ToString();
        }
        private void btn_miktar_Click(object sender, EventArgs e)//SEPETTEKİ ÜRÜNÜN MİKTARINI DEĞİŞTİRİYORUZ6
        {
            foreach (ListViewItem urun in list_sepet.CheckedItems)
            {
                list_sepet.Items[urun.Index].SubItems[3].Text = txt_miktar.Text;
                Sepet();
            }
            txt_miktar.Text = "1";
        }
        private void btn_odeme_Click(object sender, EventArgs e)
        {
            if (list_sepet.Items.Count == 0)
            {
                MessageBox.Show("Sepetiniz boş!");
            }
            else
            {
                int id;
                foreach(ListViewItem item in list_sepet.Items)
                {
                    id = int.Parse(item.SubItems[0].Text);
                    Siparis.sepetId = id;
                }
                FormOdemeA odeme = new FormOdemeA();//LOGIN DEN GELEN KULLANICI ADI!
                odeme.Show();
            }
        }
        private void btn_sil_Click(object sender, EventArgs e)//SEPETTEN SEÇİLEN ÜRÜNÜ KALDIRIYORUZ!
        {
            foreach (ListViewItem secili in list_sepet.CheckedItems)
            {
                secili.Remove();
                Sepet();
            }
            lbl_adet.Text = "(" + list_sepet.Items.Count.ToString() + ")";
            lbl_urunadet.Text = "(" + list_sepet.Items.Count.ToString() + ")";
        }
        //***************

        //TASARIM
        public Task deneme(string txt, Label label_hg, int delay)//Yazı efekti!
        {
            return Task.Run(() =>
            {
                for (int i = 0; i < txt.Length; i++)
                {
                    label_hg.Invoke((MethodInvoker)
                        delegate
                        {
                            label_hg.Text = txt.Substring(0, i);
                        });
                    System.Threading.Thread.Sleep(delay);
                };
            });
        }
        private async void metroButton1_Click(object sender, EventArgs e)//gizli buton
        {
            await deneme("KEYİFLİ ALIŞVERİŞLER DİLERİZ..", label_hg, 100);
            
        }
        private void timer_kargo_Tick(object sender, EventArgs e)
        {
            lbl_kargobilgi.Text = lbl_kargobilgi.Text.Substring(1) + lbl_kargobilgi.Text.Substring(0, 1);
        }
        private void timer1_Tick(object sender, EventArgs e)//zamanlayıcı
        {
            sure++;
            if(sure == 5)
            {
                label_hg.Visible = false;
                timer1.Stop();
            }
        }
        //***********************
        //***********************
    }
}
