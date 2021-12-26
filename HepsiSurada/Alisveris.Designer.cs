
namespace HepsiSurada
{
    partial class Alisveris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tab_control = new MetroFramework.Controls.MetroTabControl();
            this.tab_Ana = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_profil = new MetroFramework.Controls.MetroButton();
            this.btn_cikis = new MetroFramework.Controls.MetroButton();
            this.lbl_kullanici = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sepetegec = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.lbl_adet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_hg = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.combo_kategori = new MetroFramework.Controls.MetroComboBox();
            this.data_urun = new System.Windows.Forms.DataGridView();
            this.tab_Sepet = new System.Windows.Forms.TabPage();
            this.lbl_kargobilgi = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_urunadet = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_odeme = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_kargo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_vergitoplam = new System.Windows.Forms.Label();
            this.lbl_uruntoplam = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_tutar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_eksi = new System.Windows.Forms.Button();
            this.btn_miktar = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_artı = new System.Windows.Forms.Button();
            this.txt_miktar = new System.Windows.Forms.TextBox();
            this.list_sepet = new System.Windows.Forms.ListView();
            this.urunId = new System.Windows.Forms.ColumnHeader();
            this.urunAd = new System.Windows.Forms.ColumnHeader();
            this.urunAciklama = new System.Windows.Forms.ColumnHeader();
            this.urunMiktar = new System.Windows.Forms.ColumnHeader();
            this.urunFiyat = new System.Windows.Forms.ColumnHeader();
            this.timer_kargo = new System.Windows.Forms.Timer(this.components);
            this.tab_control.SuspendLayout();
            this.tab_Ana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_urun)).BeginInit();
            this.tab_Sepet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.tab_Ana);
            this.tab_control.Controls.Add(this.tab_Sepet);
            this.tab_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_control.Location = new System.Drawing.Point(0, 0);
            this.tab_control.Name = "tab_control";
            this.tab_control.Padding = new System.Drawing.Point(6, 8);
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(625, 575);
            this.tab_control.TabIndex = 0;
            this.tab_control.UseSelectable = true;
            // 
            // tab_Ana
            // 
            this.tab_Ana.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tab_Ana.Controls.Add(this.pictureBox3);
            this.tab_Ana.Controls.Add(this.pictureBox1);
            this.tab_Ana.Controls.Add(this.btn_profil);
            this.tab_Ana.Controls.Add(this.btn_cikis);
            this.tab_Ana.Controls.Add(this.lbl_kullanici);
            this.tab_Ana.Controls.Add(this.label4);
            this.tab_Ana.Controls.Add(this.label2);
            this.tab_Ana.Controls.Add(this.btn_ekle);
            this.tab_Ana.Controls.Add(this.btn_sepetegec);
            this.tab_Ana.Controls.Add(this.btn_temizle);
            this.tab_Ana.Controls.Add(this.lbl_adet);
            this.tab_Ana.Controls.Add(this.label1);
            this.tab_Ana.Controls.Add(this.label_hg);
            this.tab_Ana.Controls.Add(this.panel1);
            this.tab_Ana.Controls.Add(this.metroButton1);
            this.tab_Ana.Controls.Add(this.combo_kategori);
            this.tab_Ana.Controls.Add(this.data_urun);
            this.tab_Ana.Location = new System.Drawing.Point(4, 38);
            this.tab_Ana.Name = "tab_Ana";
            this.tab_Ana.Size = new System.Drawing.Size(617, 533);
            this.tab_Ana.TabIndex = 0;
            this.tab_Ana.Text = "ANA SAYFA";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HepsiSurada.Properties.Resources.sepet;
            this.pictureBox3.Location = new System.Drawing.Point(550, 105);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HepsiSurada.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 46);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // btn_profil
            // 
            this.btn_profil.Location = new System.Drawing.Point(230, 57);
            this.btn_profil.Name = "btn_profil";
            this.btn_profil.Size = new System.Drawing.Size(75, 15);
            this.btn_profil.TabIndex = 39;
            this.btn_profil.Text = "PROFİL";
            this.btn_profil.UseSelectable = true;
            this.btn_profil.Click += new System.EventHandler(this.btn_profil_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(149, 57);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(75, 15);
            this.btn_cikis.TabIndex = 38;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseSelectable = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // lbl_kullanici
            // 
            this.lbl_kullanici.AutoSize = true;
            this.lbl_kullanici.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_kullanici.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_kullanici.Location = new System.Drawing.Point(80, 52);
            this.lbl_kullanici.Name = "lbl_kullanici";
            this.lbl_kullanici.Size = new System.Drawing.Size(31, 21);
            this.lbl_kullanici.TabIndex = 37;
            this.lbl_kullanici.Text = "***";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "KULLANICI: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(614, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 34;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(0, 475);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(102, 55);
            this.btn_ekle.TabIndex = 27;
            this.btn_ekle.Text = "SEPETE EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sepetegec
            // 
            this.btn_sepetegec.Location = new System.Drawing.Point(462, 475);
            this.btn_sepetegec.Name = "btn_sepetegec";
            this.btn_sepetegec.Size = new System.Drawing.Size(155, 55);
            this.btn_sepetegec.TabIndex = 30;
            this.btn_sepetegec.Text = "ÖDEMEYE GEÇ";
            this.btn_sepetegec.UseVisualStyleBackColor = true;
            this.btn_sepetegec.Click += new System.EventHandler(this.btn_sepetegec_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(108, 475);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(102, 55);
            this.btn_temizle.TabIndex = 31;
            this.btn_temizle.Text = "SEPETİ BOŞALT";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // lbl_adet
            // 
            this.lbl_adet.AccessibleName = "lbl_adet";
            this.lbl_adet.AutoSize = true;
            this.lbl_adet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_adet.Location = new System.Drawing.Point(578, 108);
            this.lbl_adet.Name = "lbl_adet";
            this.lbl_adet.Size = new System.Drawing.Size(31, 21);
            this.lbl_adet.TabIndex = 26;
            this.lbl_adet.Text = "(0)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "KATEGORİ :";
            // 
            // label_hg
            // 
            this.label_hg.AutoSize = true;
            this.label_hg.Font = new System.Drawing.Font("Candara", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_hg.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_hg.Location = new System.Drawing.Point(301, 9);
            this.label_hg.Name = "label_hg";
            this.label_hg.Size = new System.Drawing.Size(308, 28);
            this.label_hg.TabIndex = 25;
            this.label_hg.Text = "KEYİFLİ ALIŞVERİŞLER DİLERİZ...";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(337, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 53);
            this.panel1.TabIndex = 24;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(361, 111);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(10, 23);
            this.metroButton1.TabIndex = 23;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // combo_kategori
            // 
            this.combo_kategori.FormattingEnabled = true;
            this.combo_kategori.ItemHeight = 23;
            this.combo_kategori.Items.AddRange(new object[] {
            "HEPSİ",
            "ELEKTRONİK",
            "MODA",
            "EV, YAŞAM",
            "YAPI MARKET",
            "OYUNCAK",
            "SPOR",
            "KİŞİSEL BAKIM",
            "KİTAP - HOBİ"});
            this.combo_kategori.Location = new System.Drawing.Point(3, 105);
            this.combo_kategori.Name = "combo_kategori";
            this.combo_kategori.Size = new System.Drawing.Size(221, 29);
            this.combo_kategori.TabIndex = 22;
            this.combo_kategori.UseSelectable = true;
            this.combo_kategori.SelectedValueChanged += new System.EventHandler(this.combo_kategori_SelectedValueChanged);
            // 
            // data_urun
            // 
            this.data_urun.AllowUserToAddRows = false;
            this.data_urun.AllowUserToDeleteRows = false;
            this.data_urun.AllowUserToResizeColumns = false;
            this.data_urun.AllowUserToResizeRows = false;
            this.data_urun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_urun.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.data_urun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_urun.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.data_urun.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.data_urun.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(195)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_urun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_urun.ColumnHeadersHeight = 35;
            this.data_urun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(166)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_urun.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_urun.EnableHeadersVisualStyles = false;
            this.data_urun.Location = new System.Drawing.Point(3, 140);
            this.data_urun.Name = "data_urun";
            this.data_urun.RowHeadersVisible = false;
            this.data_urun.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.data_urun.RowTemplate.Height = 35;
            this.data_urun.RowTemplate.ReadOnly = true;
            this.data_urun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_urun.Size = new System.Drawing.Size(611, 329);
            this.data_urun.StandardTab = true;
            this.data_urun.TabIndex = 21;
            // 
            // tab_Sepet
            // 
            this.tab_Sepet.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tab_Sepet.Controls.Add(this.lbl_kargobilgi);
            this.tab_Sepet.Controls.Add(this.pictureBox2);
            this.tab_Sepet.Controls.Add(this.groupBox2);
            this.tab_Sepet.Controls.Add(this.groupBox1);
            this.tab_Sepet.Controls.Add(this.list_sepet);
            this.tab_Sepet.Location = new System.Drawing.Point(4, 38);
            this.tab_Sepet.Name = "tab_Sepet";
            this.tab_Sepet.Size = new System.Drawing.Size(617, 533);
            this.tab_Sepet.TabIndex = 1;
            this.tab_Sepet.Text = "SEPET";
            // 
            // lbl_kargobilgi
            // 
            this.lbl_kargobilgi.AutoSize = true;
            this.lbl_kargobilgi.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_kargobilgi.Location = new System.Drawing.Point(100, 343);
            this.lbl_kargobilgi.Name = "lbl_kargobilgi";
            this.lbl_kargobilgi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_kargobilgi.Size = new System.Drawing.Size(416, 19);
            this.lbl_kargobilgi.TabIndex = 0;
            this.lbl_kargobilgi.Text = "Sepetinize 1000 TL\'lik ürün daha ekleyin kargo bedava olsun.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HepsiSurada.Properties.Resources.logo1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(305, 46);
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_urunadet);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btn_odeme);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbl_tutar);
            this.groupBox2.Location = new System.Drawing.Point(187, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 164);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            // 
            // lbl_urunadet
            // 
            this.lbl_urunadet.AutoSize = true;
            this.lbl_urunadet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_urunadet.Location = new System.Drawing.Point(307, 9);
            this.lbl_urunadet.Name = "lbl_urunadet";
            this.lbl_urunadet.Size = new System.Drawing.Size(22, 15);
            this.lbl_urunadet.TabIndex = 7;
            this.lbl_urunadet.Text = "(1)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(206, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "SEÇİLEN ÜRÜNLER";
            // 
            // btn_odeme
            // 
            this.btn_odeme.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_odeme.FlatAppearance.BorderSize = 0;
            this.btn_odeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_odeme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_odeme.Location = new System.Drawing.Point(212, 85);
            this.btn_odeme.Name = "btn_odeme";
            this.btn_odeme.Size = new System.Drawing.Size(203, 67);
            this.btn_odeme.TabIndex = 5;
            this.btn_odeme.Text = "ALIŞVERİŞİ TAMAMLA";
            this.btn_odeme.UseVisualStyleBackColor = false;
            this.btn_odeme.Click += new System.EventHandler(this.btn_odeme_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.lbl_kargo);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.lbl_vergitoplam);
            this.groupBox4.Controls.Add(this.lbl_uruntoplam);
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 164);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(35, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Kargo :";
            // 
            // lbl_kargo
            // 
            this.lbl_kargo.AutoSize = true;
            this.lbl_kargo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_kargo.Location = new System.Drawing.Point(107, 35);
            this.lbl_kargo.Name = "lbl_kargo";
            this.lbl_kargo.Size = new System.Drawing.Size(16, 21);
            this.lbl_kargo.TabIndex = 3;
            this.lbl_kargo.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(-4, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vergi(%10) :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(22, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ürünler :";
            // 
            // lbl_vergitoplam
            // 
            this.lbl_vergitoplam.AutoSize = true;
            this.lbl_vergitoplam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_vergitoplam.Location = new System.Drawing.Point(104, 108);
            this.lbl_vergitoplam.Name = "lbl_vergitoplam";
            this.lbl_vergitoplam.Size = new System.Drawing.Size(19, 21);
            this.lbl_vergitoplam.TabIndex = 3;
            this.lbl_vergitoplam.Text = "0";
            // 
            // lbl_uruntoplam
            // 
            this.lbl_uruntoplam.AutoSize = true;
            this.lbl_uruntoplam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_uruntoplam.Location = new System.Drawing.Point(104, 69);
            this.lbl_uruntoplam.Name = "lbl_uruntoplam";
            this.lbl_uruntoplam.Size = new System.Drawing.Size(19, 21);
            this.lbl_uruntoplam.TabIndex = 3;
            this.lbl_uruntoplam.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(376, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 33);
            this.label6.TabIndex = 2;
            this.label6.Text = "TL";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // lbl_tutar
            // 
            this.lbl_tutar.AutoSize = true;
            this.lbl_tutar.Font = new System.Drawing.Font("SimSun-ExtB", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tutar.Location = new System.Drawing.Point(247, 35);
            this.lbl_tutar.Name = "lbl_tutar";
            this.lbl_tutar.Size = new System.Drawing.Size(33, 34);
            this.lbl_tutar.TabIndex = 0;
            this.lbl_tutar.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_eksi);
            this.groupBox1.Controls.Add(this.btn_miktar);
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Controls.Add(this.btn_artı);
            this.groupBox1.Controls.Add(this.txt_miktar);
            this.groupBox1.Location = new System.Drawing.Point(8, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 164);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // btn_eksi
            // 
            this.btn_eksi.BackColor = System.Drawing.Color.Linen;
            this.btn_eksi.FlatAppearance.BorderSize = 0;
            this.btn_eksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eksi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_eksi.Location = new System.Drawing.Point(22, 92);
            this.btn_eksi.Name = "btn_eksi";
            this.btn_eksi.Size = new System.Drawing.Size(30, 29);
            this.btn_eksi.TabIndex = 36;
            this.btn_eksi.Text = "-";
            this.btn_eksi.UseVisualStyleBackColor = false;
            this.btn_eksi.Click += new System.EventHandler(this.btn_eksi_Click);
            // 
            // btn_miktar
            // 
            this.btn_miktar.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_miktar.Location = new System.Drawing.Point(22, 127);
            this.btn_miktar.Name = "btn_miktar";
            this.btn_miktar.Size = new System.Drawing.Size(127, 20);
            this.btn_miktar.TabIndex = 38;
            this.btn_miktar.Text = "MİKTARI DEĞİŞTİR";
            this.btn_miktar.UseVisualStyleBackColor = true;
            this.btn_miktar.Click += new System.EventHandler(this.btn_miktar_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(22, 22);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(127, 55);
            this.btn_sil.TabIndex = 37;
            this.btn_sil.Text = "SEÇİLENİ KALDIR";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_artı
            // 
            this.btn_artı.BackColor = System.Drawing.Color.Linen;
            this.btn_artı.FlatAppearance.BorderSize = 0;
            this.btn_artı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_artı.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_artı.Location = new System.Drawing.Point(119, 92);
            this.btn_artı.Name = "btn_artı";
            this.btn_artı.Size = new System.Drawing.Size(30, 29);
            this.btn_artı.TabIndex = 35;
            this.btn_artı.Text = "+";
            this.btn_artı.UseVisualStyleBackColor = false;
            this.btn_artı.Click += new System.EventHandler(this.btn_artı_Click);
            // 
            // txt_miktar
            // 
            this.txt_miktar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_miktar.Location = new System.Drawing.Point(58, 92);
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(55, 29);
            this.txt_miktar.TabIndex = 39;
            this.txt_miktar.Text = "1";
            this.txt_miktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // list_sepet
            // 
            this.list_sepet.BackColor = System.Drawing.Color.White;
            this.list_sepet.CheckBoxes = true;
            this.list_sepet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.urunId,
            this.urunAd,
            this.urunAciklama,
            this.urunMiktar,
            this.urunFiyat});
            this.list_sepet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.list_sepet.FullRowSelect = true;
            this.list_sepet.GridLines = true;
            this.list_sepet.HideSelection = false;
            this.list_sepet.Location = new System.Drawing.Point(3, 52);
            this.list_sepet.Name = "list_sepet";
            this.list_sepet.Size = new System.Drawing.Size(614, 288);
            this.list_sepet.TabIndex = 34;
            this.list_sepet.UseCompatibleStateImageBehavior = false;
            this.list_sepet.View = System.Windows.Forms.View.Details;
            // 
            // urunId
            // 
            this.urunId.Text = "SERİ NO";
            this.urunId.Width = 75;
            // 
            // urunAd
            // 
            this.urunAd.Text = "ÜRÜN ADI";
            this.urunAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.urunAd.Width = 170;
            // 
            // urunAciklama
            // 
            this.urunAciklama.Text = "AÇIKLAMA";
            this.urunAciklama.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.urunAciklama.Width = 200;
            // 
            // urunMiktar
            // 
            this.urunMiktar.Text = "MİKTAR";
            this.urunMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.urunMiktar.Width = 75;
            // 
            // urunFiyat
            // 
            this.urunFiyat.Text = "FİYAT";
            this.urunFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.urunFiyat.Width = 100;
            // 
            // timer_kargo
            // 
            this.timer_kargo.Enabled = true;
            this.timer_kargo.Interval = 80;
            this.timer_kargo.Tick += new System.EventHandler(this.timer_kargo_Tick);
            // 
            // Alisveris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(238)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(625, 575);
            this.Controls.Add(this.tab_control);
            this.Name = "Alisveris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alisveris";
            this.Load += new System.EventHandler(this.Alisveris_Load);
            this.tab_control.ResumeLayout(false);
            this.tab_Ana.ResumeLayout(false);
            this.tab_Ana.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_urun)).EndInit();
            this.tab_Sepet.ResumeLayout(false);
            this.tab_Sepet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTabControl tab_control;
        private System.Windows.Forms.TabPage tab_Ana;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sepetegec;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_hg;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox combo_kategori;
        private System.Windows.Forms.DataGridView data_urun;
        private System.Windows.Forms.TabPage tab_Sepet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_adet;
        private System.Windows.Forms.Label lbl_kullanici;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroButton btn_cikis;
        private MetroFramework.Controls.MetroButton btn_profil;
        private System.Windows.Forms.TextBox txt_miktar;
        private System.Windows.Forms.Button btn_artı;
        private System.Windows.Forms.Button btn_eksi;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_miktar;
        private System.Windows.Forms.ListView list_sepet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_tutar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_kargo;
        private System.Windows.Forms.Label lbl_uruntoplam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_kargobilgi;
        private System.Windows.Forms.Label lbl_urunadet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_odeme;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer_kargo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ColumnHeader urunId;
        private System.Windows.Forms.ColumnHeader urunAd;
        private System.Windows.Forms.ColumnHeader urunAciklama;
        private System.Windows.Forms.ColumnHeader urunMiktar;
        private System.Windows.Forms.ColumnHeader urunFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_vergitoplam;
    }
}