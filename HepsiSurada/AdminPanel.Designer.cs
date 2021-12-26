
namespace HepsiSurada
{
    partial class AdminPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tab_panel = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.combo_kategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.txt_uid = new System.Windows.Forms.TextBox();
            this.btn_usil = new System.Windows.Forms.Button();
            this.txt_uad = new System.Windows.Forms.TextBox();
            this.btn_uguncelle = new System.Windows.Forms.Button();
            this.btn_yeni = new System.Windows.Forms.Button();
            this.txt_uaciklama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ustok = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ufiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_uagirlik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.data_urun = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_kadres = new System.Windows.Forms.TextBox();
            this.txt_kad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_ksil = new MetroFramework.Controls.MetroButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_keposta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_kid = new System.Windows.Forms.TextBox();
            this.txt_ktelefon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_ksoyad = new System.Windows.Forms.TextBox();
            this.txt_kullanici = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.data_kullanici = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_guncelle = new MetroFramework.Controls.MetroButton();
            this.txt_siparisno = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.combo_durum = new MetroFramework.Controls.MetroComboBox();
            this.data_siparis = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tab_panel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_urun)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_kullanici)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_siparis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_panel
            // 
            this.tab_panel.Controls.Add(this.tabPage1);
            this.tab_panel.Controls.Add(this.tabPage2);
            this.tab_panel.Controls.Add(this.tabPage3);
            this.tab_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_panel.Location = new System.Drawing.Point(0, 0);
            this.tab_panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_panel.Name = "tab_panel";
            this.tab_panel.Padding = new System.Drawing.Point(6, 8);
            this.tab_panel.SelectedIndex = 0;
            this.tab_panel.Size = new System.Drawing.Size(810, 579);
            this.tab_panel.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_panel.Style = MetroFramework.MetroColorStyle.Yellow;
            this.tab_panel.TabIndex = 0;
            this.tab_panel.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.CausesValidation = false;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.data_urun);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(802, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ÜRÜNLER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.combo_kategori);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_temizle);
            this.panel1.Controls.Add(this.txt_uid);
            this.panel1.Controls.Add(this.btn_usil);
            this.panel1.Controls.Add(this.txt_uad);
            this.panel1.Controls.Add(this.btn_uguncelle);
            this.panel1.Controls.Add(this.btn_yeni);
            this.panel1.Controls.Add(this.txt_uaciklama);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_ustok);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_ufiyat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_uagirlik);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 288);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 234);
            this.panel1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(705, 161);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 67);
            this.button1.TabIndex = 16;
            this.button1.Text = "ÇIKIŞ YAP";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // combo_kategori
            // 
            this.combo_kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_kategori.Items.AddRange(new object[] {
            "ELEKTRONİK",
            "MODA",
            "EV, YAŞAM",
            "YAPI MARKET",
            "OYUNCAK",
            "SPOR",
            "KİŞİSEL BAKIM",
            "KİTAP - HOBİ"});
            this.combo_kategori.Location = new System.Drawing.Point(209, 61);
            this.combo_kategori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo_kategori.Name = "combo_kategori";
            this.combo_kategori.Size = new System.Drawing.Size(199, 28);
            this.combo_kategori.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID:";
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_temizle.Location = new System.Drawing.Point(3, 161);
            this.btn_temizle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(86, 67);
            this.btn_temizle.TabIndex = 14;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // txt_uid
            // 
            this.txt_uid.Enabled = false;
            this.txt_uid.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_uid.ForeColor = System.Drawing.Color.IndianRed;
            this.txt_uid.Location = new System.Drawing.Point(36, 12);
            this.txt_uid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.PlaceholderText = "ID";
            this.txt_uid.ReadOnly = true;
            this.txt_uid.Size = new System.Drawing.Size(44, 30);
            this.txt_uid.TabIndex = 9;
            this.txt_uid.Validated += new System.EventHandler(this.btn_usil_Click);
            // 
            // btn_usil
            // 
            this.btn_usil.BackColor = System.Drawing.Color.LightCoral;
            this.btn_usil.Location = new System.Drawing.Point(394, 161);
            this.btn_usil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_usil.Name = "btn_usil";
            this.btn_usil.Size = new System.Drawing.Size(86, 67);
            this.btn_usil.TabIndex = 13;
            this.btn_usil.Text = "SİL";
            this.btn_usil.UseVisualStyleBackColor = false;
            this.btn_usil.Click += new System.EventHandler(this.btn_usil_Click);
            // 
            // txt_uad
            // 
            this.txt_uad.Location = new System.Drawing.Point(209, 12);
            this.txt_uad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_uad.Name = "txt_uad";
            this.txt_uad.PlaceholderText = "ADI";
            this.txt_uad.Size = new System.Drawing.Size(199, 27);
            this.txt_uad.TabIndex = 10;
            // 
            // btn_uguncelle
            // 
            this.btn_uguncelle.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_uguncelle.Location = new System.Drawing.Point(302, 161);
            this.btn_uguncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_uguncelle.Name = "btn_uguncelle";
            this.btn_uguncelle.Size = new System.Drawing.Size(86, 67);
            this.btn_uguncelle.TabIndex = 13;
            this.btn_uguncelle.Text = "GÜNCELLE";
            this.btn_uguncelle.UseVisualStyleBackColor = false;
            this.btn_uguncelle.Click += new System.EventHandler(this.btn_uguncelle_Click);
            // 
            // btn_yeni
            // 
            this.btn_yeni.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_yeni.FlatAppearance.BorderSize = 0;
            this.btn_yeni.Location = new System.Drawing.Point(209, 161);
            this.btn_yeni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_yeni.Name = "btn_yeni";
            this.btn_yeni.Size = new System.Drawing.Size(86, 67);
            this.btn_yeni.TabIndex = 12;
            this.btn_yeni.Text = "ÜRÜN EKLE";
            this.btn_yeni.UseVisualStyleBackColor = false;
            this.btn_yeni.Click += new System.EventHandler(this.btn_uyeni_Click);
            // 
            // txt_uaciklama
            // 
            this.txt_uaciklama.Location = new System.Drawing.Point(539, 112);
            this.txt_uaciklama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_uaciklama.Multiline = true;
            this.txt_uaciklama.Name = "txt_uaciklama";
            this.txt_uaciklama.PlaceholderText = "BAŞLICA ÖZELLİKLER";
            this.txt_uaciklama.Size = new System.Drawing.Size(199, 29);
            this.txt_uaciklama.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(431, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "AĞIRLIK :";
            // 
            // txt_ustok
            // 
            this.txt_ustok.Location = new System.Drawing.Point(209, 112);
            this.txt_ustok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ustok.Name = "txt_ustok";
            this.txt_ustok.PlaceholderText = "ADET";
            this.txt_ustok.Size = new System.Drawing.Size(199, 27);
            this.txt_ustok.TabIndex = 10;
            this.txt_ustok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ustok_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(431, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "FİYAT :";
            // 
            // txt_ufiyat
            // 
            this.txt_ufiyat.Location = new System.Drawing.Point(539, 12);
            this.txt_ufiyat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ufiyat.Name = "txt_ufiyat";
            this.txt_ufiyat.PlaceholderText = "TL";
            this.txt_ufiyat.Size = new System.Drawing.Size(199, 27);
            this.txt_ufiyat.TabIndex = 10;
            this.txt_ufiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ufiyat_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(106, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "STOK :";
            // 
            // txt_uagirlik
            // 
            this.txt_uagirlik.Location = new System.Drawing.Point(539, 61);
            this.txt_uagirlik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_uagirlik.Name = "txt_uagirlik";
            this.txt_uagirlik.PlaceholderText = "GRAM";
            this.txt_uagirlik.Size = new System.Drawing.Size(199, 27);
            this.txt_uagirlik.TabIndex = 10;
            this.txt_uagirlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_uagirlik_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(431, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "AÇIKLAMA :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(106, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "ADI :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(106, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "KATEGORİ :";
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
            this.data_urun.Location = new System.Drawing.Point(0, 0);
            this.data_urun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_urun.Name = "data_urun";
            this.data_urun.RowHeadersVisible = false;
            this.data_urun.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.data_urun.RowTemplate.Height = 35;
            this.data_urun.RowTemplate.ReadOnly = true;
            this.data_urun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_urun.Size = new System.Drawing.Size(801, 280);
            this.data_urun.StandardTab = true;
            this.data_urun.TabIndex = 6;
            this.data_urun.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_urun_CellMouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.data_kullanici);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(802, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "KULLANICILAR";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_kadres);
            this.panel2.Controls.Add(this.txt_kad);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btn_ksil);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_keposta);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txt_kid);
            this.panel2.Controls.Add(this.txt_ktelefon);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txt_ksoyad);
            this.panel2.Controls.Add(this.txt_kullanici);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(0, 288);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 234);
            this.panel2.TabIndex = 10;
            // 
            // txt_kadres
            // 
            this.txt_kadres.Enabled = false;
            this.txt_kadres.Location = new System.Drawing.Point(551, 97);
            this.txt_kadres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_kadres.Multiline = true;
            this.txt_kadres.Name = "txt_kadres";
            this.txt_kadres.ReadOnly = true;
            this.txt_kadres.Size = new System.Drawing.Size(211, 63);
            this.txt_kadres.TabIndex = 2;
            // 
            // txt_kad
            // 
            this.txt_kad.Enabled = false;
            this.txt_kad.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_kad.Location = new System.Drawing.Point(246, 20);
            this.txt_kad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_kad.Name = "txt_kad";
            this.txt_kad.ReadOnly = true;
            this.txt_kad.Size = new System.Drawing.Size(199, 30);
            this.txt_kad.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(153, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "AD :";
            // 
            // btn_ksil
            // 
            this.btn_ksil.Location = new System.Drawing.Point(246, 160);
            this.btn_ksil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ksil.Name = "btn_ksil";
            this.btn_ksil.Size = new System.Drawing.Size(200, 47);
            this.btn_ksil.TabIndex = 4;
            this.btn_ksil.Text = "SİL";
            this.btn_ksil.UseSelectable = true;
            this.btn_ksil.Click += new System.EventHandler(this.btn_ksil_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(153, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 23);
            this.label14.TabIndex = 3;
            this.label14.Text = "KUL. ADI :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(21, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID:";
            // 
            // txt_keposta
            // 
            this.txt_keposta.Enabled = false;
            this.txt_keposta.Location = new System.Drawing.Point(551, 59);
            this.txt_keposta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_keposta.Name = "txt_keposta";
            this.txt_keposta.ReadOnly = true;
            this.txt_keposta.Size = new System.Drawing.Size(211, 27);
            this.txt_keposta.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(471, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 23);
            this.label12.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(153, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 23);
            this.label15.TabIndex = 3;
            this.label15.Text = "TELEFON :";
            // 
            // txt_kid
            // 
            this.txt_kid.Enabled = false;
            this.txt_kid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_kid.Location = new System.Drawing.Point(58, 17);
            this.txt_kid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_kid.Name = "txt_kid";
            this.txt_kid.PlaceholderText = "ID";
            this.txt_kid.ReadOnly = true;
            this.txt_kid.Size = new System.Drawing.Size(41, 30);
            this.txt_kid.TabIndex = 1;
            // 
            // txt_ktelefon
            // 
            this.txt_ktelefon.Enabled = false;
            this.txt_ktelefon.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_ktelefon.Location = new System.Drawing.Point(246, 96);
            this.txt_ktelefon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ktelefon.Name = "txt_ktelefon";
            this.txt_ktelefon.ReadOnly = true;
            this.txt_ktelefon.Size = new System.Drawing.Size(199, 30);
            this.txt_ktelefon.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(458, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "SOYAD :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(458, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 23);
            this.label11.TabIndex = 3;
            this.label11.Text = "ADRES :";
            // 
            // txt_ksoyad
            // 
            this.txt_ksoyad.Enabled = false;
            this.txt_ksoyad.Location = new System.Drawing.Point(551, 20);
            this.txt_ksoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ksoyad.Name = "txt_ksoyad";
            this.txt_ksoyad.ReadOnly = true;
            this.txt_ksoyad.Size = new System.Drawing.Size(211, 27);
            this.txt_ksoyad.TabIndex = 2;
            // 
            // txt_kullanici
            // 
            this.txt_kullanici.Enabled = false;
            this.txt_kullanici.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_kullanici.Location = new System.Drawing.Point(246, 59);
            this.txt_kullanici.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_kullanici.Name = "txt_kullanici";
            this.txt_kullanici.ReadOnly = true;
            this.txt_kullanici.Size = new System.Drawing.Size(199, 30);
            this.txt_kullanici.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(458, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 23);
            this.label13.TabIndex = 3;
            this.label13.Text = "E-POSTA :";
            // 
            // data_kullanici
            // 
            this.data_kullanici.AllowUserToAddRows = false;
            this.data_kullanici.AllowUserToDeleteRows = false;
            this.data_kullanici.AllowUserToResizeColumns = false;
            this.data_kullanici.AllowUserToResizeRows = false;
            this.data_kullanici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_kullanici.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.data_kullanici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_kullanici.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.data_kullanici.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.data_kullanici.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(195)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_kullanici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data_kullanici.ColumnHeadersHeight = 35;
            this.data_kullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(166)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_kullanici.DefaultCellStyle = dataGridViewCellStyle4;
            this.data_kullanici.EnableHeadersVisualStyles = false;
            this.data_kullanici.Location = new System.Drawing.Point(0, 0);
            this.data_kullanici.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_kullanici.Name = "data_kullanici";
            this.data_kullanici.RowHeadersVisible = false;
            this.data_kullanici.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.data_kullanici.RowTemplate.Height = 35;
            this.data_kullanici.RowTemplate.ReadOnly = true;
            this.data_kullanici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_kullanici.Size = new System.Drawing.Size(801, 280);
            this.data_kullanici.StandardTab = true;
            this.data_kullanici.TabIndex = 7;
            this.data_kullanici.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.data_kullanici_CellFormatting);
            this.data_kullanici.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_kullanici_CellMouseClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_guncelle);
            this.tabPage3.Controls.Add(this.txt_siparisno);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.combo_durum);
            this.tabPage3.Controls.Add(this.data_siparis);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(802, 537);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SİPARİŞLER";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(623, 439);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(134, 39);
            this.btn_guncelle.TabIndex = 13;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseSelectable = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // txt_siparisno
            // 
            this.txt_siparisno.Enabled = false;
            this.txt_siparisno.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_siparisno.ForeColor = System.Drawing.Color.Red;
            this.txt_siparisno.Location = new System.Drawing.Point(137, 439);
            this.txt_siparisno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_siparisno.Name = "txt_siparisno";
            this.txt_siparisno.ReadOnly = true;
            this.txt_siparisno.Size = new System.Drawing.Size(46, 34);
            this.txt_siparisno.TabIndex = 12;
            this.txt_siparisno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(9, 440);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(134, 30);
            this.label17.TabIndex = 10;
            this.label17.Text = "Sipariş NO :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(232, 439);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(184, 30);
            this.label16.TabIndex = 10;
            this.label16.Text = "Sipariş Durumu :";
            // 
            // combo_durum
            // 
            this.combo_durum.FormattingEnabled = true;
            this.combo_durum.ItemHeight = 23;
            this.combo_durum.Items.AddRange(new object[] {
            "HAZIRLANIYOR",
            "YOLDA",
            "TAMAMLANDI",
            "İADE"});
            this.combo_durum.Location = new System.Drawing.Point(413, 439);
            this.combo_durum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.combo_durum.Name = "combo_durum";
            this.combo_durum.Size = new System.Drawing.Size(203, 29);
            this.combo_durum.TabIndex = 9;
            this.combo_durum.UseSelectable = true;
            // 
            // data_siparis
            // 
            this.data_siparis.AllowUserToAddRows = false;
            this.data_siparis.AllowUserToDeleteRows = false;
            this.data_siparis.AllowUserToResizeColumns = false;
            this.data_siparis.AllowUserToResizeRows = false;
            this.data_siparis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_siparis.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.data_siparis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_siparis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.data_siparis.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.data_siparis.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(195)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_siparis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.data_siparis.ColumnHeadersHeight = 35;
            this.data_siparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(166)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_siparis.DefaultCellStyle = dataGridViewCellStyle6;
            this.data_siparis.Dock = System.Windows.Forms.DockStyle.Top;
            this.data_siparis.EnableHeadersVisualStyles = false;
            this.data_siparis.Location = new System.Drawing.Point(0, 0);
            this.data_siparis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_siparis.Name = "data_siparis";
            this.data_siparis.RowHeadersVisible = false;
            this.data_siparis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.data_siparis.RowTemplate.Height = 35;
            this.data_siparis.RowTemplate.ReadOnly = true;
            this.data_siparis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_siparis.Size = new System.Drawing.Size(802, 404);
            this.data_siparis.StandardTab = true;
            this.data_siparis.TabIndex = 7;
            this.data_siparis.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_siparis_CellMouseClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 579);
            this.Controls.Add(this.tab_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel -HepsiSurada";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.tab_panel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_urun)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_kullanici)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_siparis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tab_panel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView data_urun;
        private System.Windows.Forms.TextBox txt_uid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ustok;
        private System.Windows.Forms.TextBox txt_uaciklama;
        private System.Windows.Forms.TextBox txt_uad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_uagirlik;
        private System.Windows.Forms.TextBox txt_ufiyat;
        private System.Windows.Forms.Button btn_usil;
        private System.Windows.Forms.Button btn_uguncelle;
        private System.Windows.Forms.Button btn_yeni;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox combo_kategori;
        private System.Windows.Forms.DataGridView data_kullanici;
        private System.Windows.Forms.TextBox txt_kid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ksoyad;
        private System.Windows.Forms.TextBox txt_kad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_kadres;
        private System.Windows.Forms.TextBox txt_keposta;
        private System.Windows.Forms.TextBox txt_kullanici;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private MetroFramework.Controls.MetroButton btn_ksil;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_ktelefon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt_siparisno;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private MetroFramework.Controls.MetroComboBox combo_durum;
        private System.Windows.Forms.DataGridView data_siparis;
        private MetroFramework.Controls.MetroButton btn_guncelle;
        private System.Windows.Forms.Button button1;
    }
}