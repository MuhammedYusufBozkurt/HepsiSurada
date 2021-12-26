
namespace HepsiSurada
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_kulsif = new System.Windows.Forms.TextBox();
            this.txt_kulad = new System.Windows.Forms.TextBox();
            this.check_pasvis = new System.Windows.Forms.CheckBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.link_unuttum = new MetroFramework.Controls.MetroLink();
            this.link_yeni = new MetroFramework.Controls.MetroLink();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(679, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(214)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 125);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::HepsiSurada.Properties.Resources.logo;
            this.pictureBox4.Location = new System.Drawing.Point(63, 81);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(225, 50);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HepsiSurada.Properties.Resources.login;
            this.pictureBox2.Location = new System.Drawing.Point(127, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // txt_kulsif
            // 
            this.txt_kulsif.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_kulsif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(234)))), ((int)(((byte)(220)))));
            this.txt_kulsif.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_kulsif.Location = new System.Drawing.Point(102, 197);
            this.txt_kulsif.Name = "txt_kulsif";
            this.txt_kulsif.PasswordChar = '*';
            this.txt_kulsif.PlaceholderText = "ŞİFRE";
            this.txt_kulsif.Size = new System.Drawing.Size(153, 27);
            this.txt_kulsif.TabIndex = 4;
            // 
            // txt_kulad
            // 
            this.txt_kulad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_kulad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(234)))), ((int)(((byte)(220)))));
            this.txt_kulad.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_kulad.Location = new System.Drawing.Point(102, 154);
            this.txt_kulad.Name = "txt_kulad";
            this.txt_kulad.PlaceholderText = "KULLANICI ADI";
            this.txt_kulad.Size = new System.Drawing.Size(153, 27);
            this.txt_kulad.TabIndex = 4;
            // 
            // check_pasvis
            // 
            this.check_pasvis.AutoSize = true;
            this.check_pasvis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(234)))), ((int)(((byte)(220)))));
            this.check_pasvis.Location = new System.Drawing.Point(261, 204);
            this.check_pasvis.Name = "check_pasvis";
            this.check_pasvis.Size = new System.Drawing.Size(15, 14);
            this.check_pasvis.TabIndex = 7;
            this.check_pasvis.UseVisualStyleBackColor = false;
            this.check_pasvis.CheckedChanged += new System.EventHandler(this.check_pasvis_CheckedChanged_1);
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(214)))));
            this.btn_giris.FlatAppearance.BorderSize = 0;
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_giris.Location = new System.Drawing.Point(102, 241);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(153, 40);
            this.btn_giris.TabIndex = 8;
            this.btn_giris.Text = "GİRİŞ YAP";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click_1);
            // 
            // link_unuttum
            // 
            this.link_unuttum.BackColor = System.Drawing.Color.Transparent;
            this.link_unuttum.Location = new System.Drawing.Point(12, 310);
            this.link_unuttum.Name = "link_unuttum";
            this.link_unuttum.Size = new System.Drawing.Size(102, 23);
            this.link_unuttum.TabIndex = 9;
            this.link_unuttum.Text = "Şifremi unuttum";
            this.link_unuttum.UseCustomBackColor = true;
            this.link_unuttum.UseSelectable = true;
            this.link_unuttum.UseVisualStyleBackColor = false;
            this.link_unuttum.Click += new System.EventHandler(this.link_unuttum_Click);
            // 
            // link_yeni
            // 
            this.link_yeni.BackColor = System.Drawing.Color.Transparent;
            this.link_yeni.Location = new System.Drawing.Point(263, 310);
            this.link_yeni.Name = "link_yeni";
            this.link_yeni.Size = new System.Drawing.Size(75, 23);
            this.link_yeni.TabIndex = 10;
            this.link_yeni.Text = "ÜYE OL";
            this.link_yeni.UseCustomBackColor = true;
            this.link_yeni.UseSelectable = true;
            this.link_yeni.UseVisualStyleBackColor = false;
            this.link_yeni.Click += new System.EventHandler(this.link_yeni_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HepsiSurada.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(71, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HepsiSurada.Properties.Resources.key;
            this.pictureBox3.Location = new System.Drawing.Point(71, 197);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 27);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(350, 345);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.link_yeni);
            this.Controls.Add(this.link_unuttum);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.check_pasvis);
            this.Controls.Add(this.txt_kulad);
            this.Controls.Add(this.txt_kulsif);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_kulsif;
        private System.Windows.Forms.TextBox txt_kulad;
        private System.Windows.Forms.CheckBox check_pasvis;
        private System.Windows.Forms.Button btn_giris;
        private MetroFramework.Controls.MetroLink link_unuttum;
        private MetroFramework.Controls.MetroLink link_yeni;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

