namespace OkultoSinavTakip
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            TxtAD = new TextBox();
            TxtSoyad = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            BtnYesil = new Button();
            BtnTuruncu = new Button();
            BtnSari = new Button();
            BtnMavi = new Button();
            BtnBeyaz = new Button();
            BtnPembe = new Button();
            groupBox4 = new GroupBox();
            BtnKaydet = new Button();
            BtnTemizle = new Button();
            BtnHesapla = new Button();
            groupBox5 = new GroupBox();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtAD);
            groupBox1.Controls.Add(TxtSoyad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(30, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci  Bilgisi";
            // 
            // TxtAD
            // 
            TxtAD.Location = new Point(66, 30);
            TxtAD.Name = "TxtAD";
            TxtAD.Size = new Size(141, 23);
            TxtAD.TabIndex = 3;
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(66, 55);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(141, 23);
            TxtSoyad.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 38);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(284, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(285, 145);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sınav Notları";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(210, 47);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(75, 23);
            textBox5.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(152, 47);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 12;
            label7.Text = "Proje:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(212, 18);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(67, 23);
            textBox4.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(143, 21);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 10;
            label6.Text = "sınav 3:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(73, 15);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(75, 23);
            textBox3.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 19);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 8;
            label5.Text = "sınav 1:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(63, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(75, 23);
            textBox2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 86);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 6;
            label4.Text = "Ortalama:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(75, 23);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 47);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 4;
            label3.Text = "sınav 2:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnYesil);
            groupBox3.Controls.Add(BtnTuruncu);
            groupBox3.Controls.Add(BtnSari);
            groupBox3.Controls.Add(BtnMavi);
            groupBox3.Controls.Add(BtnBeyaz);
            groupBox3.Controls.Add(BtnPembe);
            groupBox3.Location = new Point(37, 167);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(241, 139);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "  Renkler";
            // 
            // BtnYesil
            // 
            BtnYesil.Location = new Point(98, 99);
            BtnYesil.Name = "BtnYesil";
            BtnYesil.Size = new Size(80, 27);
            BtnYesil.TabIndex = 3;
            BtnYesil.Text = "Yeşil";
            BtnYesil.UseVisualStyleBackColor = true;
            BtnYesil.Click += BtnYesil_Click;
            // 
            // BtnTuruncu
            // 
            BtnTuruncu.Location = new Point(98, 60);
            BtnTuruncu.Name = "BtnTuruncu";
            BtnTuruncu.Size = new Size(80, 27);
            BtnTuruncu.TabIndex = 2;
            BtnTuruncu.Text = "Turuncu";
            BtnTuruncu.UseVisualStyleBackColor = true;
            BtnTuruncu.Click += BtnTuruncu_Click;
            // 
            // BtnSari
            // 
            BtnSari.Location = new Point(98, 22);
            BtnSari.Name = "BtnSari";
            BtnSari.Size = new Size(80, 27);
            BtnSari.TabIndex = 1;
            BtnSari.Text = "Sarı";
            BtnSari.UseVisualStyleBackColor = true;
            BtnSari.Click += BtnSari_Click;
            // 
            // BtnMavi
            // 
            BtnMavi.Location = new Point(6, 22);
            BtnMavi.Name = "BtnMavi";
            BtnMavi.Size = new Size(86, 32);
            BtnMavi.TabIndex = 0;
            BtnMavi.Text = "Mavi";
            BtnMavi.UseVisualStyleBackColor = true;
            BtnMavi.Click += BtnMavi_Click;
            // 
            // BtnBeyaz
            // 
            BtnBeyaz.Location = new Point(5, 60);
            BtnBeyaz.Name = "BtnBeyaz";
            BtnBeyaz.Size = new Size(87, 27);
            BtnBeyaz.TabIndex = 0;
            BtnBeyaz.Text = "Beyaz";
            BtnBeyaz.UseVisualStyleBackColor = true;
            BtnBeyaz.Click += BtnBeyaz_Click;
            // 
            // BtnPembe
            // 
            BtnPembe.Location = new Point(5, 93);
            BtnPembe.Name = "BtnPembe";
            BtnPembe.Size = new Size(87, 33);
            BtnPembe.TabIndex = 0;
            BtnPembe.Text = "Pembe";
            BtnPembe.UseVisualStyleBackColor = true;
            BtnPembe.Click += BtnPembe_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BtnKaydet);
            groupBox4.Controls.Add(BtnTemizle);
            groupBox4.Controls.Add(BtnHesapla);
            groupBox4.Location = new Point(284, 167);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(285, 139);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = " ";
            // 
            // BtnKaydet
            // 
            BtnKaydet.Location = new Point(73, 80);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(167, 23);
            BtnKaydet.TabIndex = 2;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            // 
            // BtnTemizle
            // 
            BtnTemizle.Location = new Point(73, 51);
            BtnTemizle.Name = "BtnTemizle";
            BtnTemizle.Size = new Size(167, 23);
            BtnTemizle.TabIndex = 1;
            BtnTemizle.Text = "Temizle";
            BtnTemizle.UseVisualStyleBackColor = true;
            // 
            // BtnHesapla
            // 
            BtnHesapla.Location = new Point(73, 22);
            BtnHesapla.Name = "BtnHesapla";
            BtnHesapla.Size = new Size(167, 23);
            BtnHesapla.TabIndex = 0;
            BtnHesapla.Text = "Hesapla";
            BtnHesapla.UseVisualStyleBackColor = true;
            BtnHesapla.Click += BtnHesapla_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(listBox1);
            groupBox5.Location = new Point(12, 312);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(557, 131);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Liste";
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 19);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(551, 109);
            listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 444);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TextBox TxtAD;
        private TextBox TxtSoyad;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox4;
        private Label label6;
        private Button BtnMavi;
        private Button BtnBeyaz;
        private Button BtnPembe;
        private Button BtnSari;
        private Button BtnYesil;
        private Button BtnTuruncu;
        private Button BtnKaydet;
        private Button BtnTemizle;
        private Button BtnHesapla;
        private ListBox listBox1;
    }
}
