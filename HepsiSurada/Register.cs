using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace HepsiSurada
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            //TASARIM KODLARI
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            timer1.Start();
            //BİTİŞ
        }
        //TASARIM İLE İLGİLİ KODLAR  -başlangıç
        public int sure;
        private void timer1_Tick(object sender, EventArgs e)//sure değişkenini tutuyor!
        {
            sure++;
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        Point lastPoint;
        private void Register_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Register_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        //BİTİŞ
        private void btn_kayit_Click(object sender, EventArgs e)
        {
            Kullanici kul = new Kullanici();

            if(txt_sifre.Text == txt_sifreonay.Text) 
            {
                kul.Ad = txt_ad.Text;
                kul.Soyad = txt_soyad.Text;
                kul.KullaniciAd = txt_kulad.Text;
                kul.Sifre = txt_sifre.Text;
                kul.Eposta = txt_eposta.Text;
                kul.Telefon = int.Parse(txt_telefon.Text);
                kul.Adres = txt_adres.Text;
                if(kul.ekleKullanici(kul))
                {
                    MessageBox.Show("Kayıt başarılı..");
                    this.Hide();
                    Login lo = new Login();
                    lo.Show();
                }
                else 
                {
                    MessageBox.Show("Kullanıcı adı daha önce alınmış!");
                }
            }
            else
            {
                MessageBox.Show("Şifreler aynı değil!");
            }
            
        }

        private void link_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lo = new Login();
            lo.Show();
        }

        private void txt_telefon_TextChanged(object sender, EventArgs e)//TELEFON TEXTBOX a sadece numara girilir!
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_telefon.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txt_telefon.Text = txt_telefon.Text.Remove(txt_telefon.Text.Length - 1);
            }
        }
    }
}
