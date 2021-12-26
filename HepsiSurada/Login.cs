using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HepsiSurada
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //TASARIM KODLARI
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //BİTİŞ
            Kullanici k = new Kullanici();
            k.Listele();


        }

        //TASARIM İLE İLGİLİ KODLAR  -başlangıç
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
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Login_MouseDown(object sender, MouseEventArgs e)
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
        private void btn_giris_Click_1(object sender, EventArgs e)
        {
            if (txt_kulad.Text != "" && txt_kulsif.Text != "")
            {
                Kullanici kul = new Kullanici();
                kul = kul.girisKullanici(txt_kulad.Text, txt_kulsif.Text);//kullanıcı var ise islem dolu geliyor
                if (kul.Yetki == true)// yetkisi true olan admin
                {
                    this.Hide();
                    AdminPanel a = new AdminPanel();
                    a.Show();
                }
                else if (kul != null)//yetkisi false olan kullanıcı
                {
                    this.Hide();
                    kul.KullaniciDetay(kul.Id);//Login olan kullanıcının bilgilerini static değişkene atıyoruz!
                    Alisveris a = new Alisveris();
                    a.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                }
            }
        }
        private void check_pasvis_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_kulsif.PasswordChar = default;
            if (!check_pasvis.Checked)
            {
                txt_kulsif.PasswordChar = '*';
            }
        }
        private void link_yeni_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Register r = new Register();
            r.Show();
        }
        private void link_unuttum_Click(object sender, EventArgs e)
        {
            Unuttum u = new Unuttum();
            u.Show();
        }
    }
}
