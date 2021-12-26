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
    public partial class Unuttum : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Unuttum()
        {
            conn = new SqlConnection("Data Source=DESKTOP-68V49NQ;Initial Catalog=HepsiSurada;Integrated Security=True");
            cmd = new SqlCommand();
            InitializeComponent();
        }
        string eposta;
        private void metroButton1_Click(object sender, EventArgs e)
        {
            eposta = txt_eposta.Text.Trim();
            cmd = new SqlCommand("SELECT Sifre FROM Kullanicilar WHERE Eposta='" + eposta + "'", conn);
            conn.Open();
            SqlDataReader oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("ŞİFRENİZ : " + oku[0].ToString());
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATA");
            }
            conn.Close();
        }
    }
}
