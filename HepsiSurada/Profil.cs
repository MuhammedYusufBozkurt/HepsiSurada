using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace HepsiSurada
{
    public partial class Profil : Form
    {
        public Profil(int id)
        {
            InitializeComponent();
            Bilgiler(id);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public void Bilgiler(int id)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-68V49NQ;Initial Catalog=HepsiSurada;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanicilar WHERE Id='" + id + "'", conn);
            conn.Open();
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                txt_id.Text = oku[0].ToString();
                txt_ad.Text = oku[1].ToString();
                txt_soyad.Text = oku[2].ToString();
                txt_kulad.Text = oku[3].ToString();
                txt_eposta.Text = oku[5].ToString();
                txt_telefon.Text = oku[6].ToString();
                txt_adres.Text = oku[7].ToString();
            }
            conn.Close();
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
        private void Profil_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Profil_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
