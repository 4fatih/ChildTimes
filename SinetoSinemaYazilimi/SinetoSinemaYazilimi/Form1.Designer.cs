namespace SinetoSinemaYazilimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            lblToplam = new Label();
            label16 = new Label();
            label15 = new Label();
            groupBox4 = new GroupBox();
            comboBox4 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label13 = new Label();
            label11 = new Label();
            label7 = new Label();
            label4 = new Label();
            label2 = new Label();
            groupBox5 = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox3 = new GroupBox();
            suS = new TextBox();
            cayS = new TextBox();
            sutS = new TextBox();
            misirS = new TextBox();
            biletS = new TextBox();
            label14 = new Label();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            linkLabel1 = new LinkLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(385, 69);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " Yetkili";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 30);
            label1.Name = "label1";
            label1.Size = new Size(259, 15);
            label1.TabIndex = 10;
            label1.Text = "Muhammed Fatih Yazıcı - Sineto Sinema Salonu";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(lblToplam);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Location = new Point(537, 131);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(230, 220);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ödeme Ekranı";
            // 
            // button1
            // 
            button1.Location = new Point(69, 114);
            button1.Name = "button1";
            button1.Size = new Size(90, 38);
            button1.TabIndex = 7;
            button1.Text = "hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblToplam
            // 
            lblToplam.AutoSize = true;
            lblToplam.Location = new Point(89, 69);
            lblToplam.Name = "lblToplam";
            lblToplam.Size = new Size(31, 15);
            lblToplam.TabIndex = 6;
            lblToplam.Text = "00TL";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(88, 69);
            label16.Name = "label16";
            label16.Size = new Size(13, 15);
            label16.TabIndex = 4;
            label16.Text = "  ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 69);
            label15.Name = "label15";
            label15.Size = new Size(76, 15);
            label15.TabIndex = 3;
            label15.Text = "Toplam Tutar";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBox4);
            groupBox4.Controls.Add(dateTimePicker1);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label2);
            groupBox4.Location = new Point(12, 131);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(240, 220);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Fiyat";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { " supermen", "hulk", "betmen", "kabtaamerika", " buzdevri", "kıral şakir" });
            comboBox4.Location = new Point(9, 226);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(87, -29);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 37);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 11;
            label5.Text = "Bilet 250TL";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(16, 66);
            label13.Name = "label13";
            label13.Size = new Size(56, 15);
            label13.TabIndex = 9;
            label13.Text = "Mısır 5TL";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(16, 98);
            label11.Name = "label11";
            label11.Size = new Size(53, 15);
            label11.TabIndex = 7;
            label11.Text = "Süt 10TL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(16, 134);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 2;
            label7.Text = "Çay 5TL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 169);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 2;
            label4.Text = "Su 5TL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 100);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(comboBox1);
            groupBox5.Location = new Point(415, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(352, 69);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Fılim Listesi";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Hulk", "Babam ve Oğlum", "Örümcek Adam", "Peygamber Efendimizin Hayatı", "Hazreti Yusufun Hayatı", "Hazreti İsa", "Kral Şakir", "Süper Bir Takım" });
            comboBox1.Location = new Point(6, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(284, 23);
            comboBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(suS);
            groupBox3.Controls.Add(cayS);
            groupBox3.Controls.Add(sutS);
            groupBox3.Controls.Add(misirS);
            groupBox3.Controls.Add(biletS);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(linkLabel1);
            groupBox3.Location = new Point(258, 131);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(259, 220);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sipariş:";
            // 
            // suS
            // 
            suS.Location = new Point(89, 155);
            suS.Name = "suS";
            suS.Size = new Size(100, 23);
            suS.TabIndex = 12;
            // 
            // cayS
            // 
            cayS.Location = new Point(89, 126);
            cayS.Name = "cayS";
            cayS.Size = new Size(100, 23);
            cayS.TabIndex = 12;
            // 
            // sutS
            // 
            sutS.Location = new Point(89, 97);
            sutS.Name = "sutS";
            sutS.Size = new Size(100, 23);
            sutS.TabIndex = 12;
            // 
            // misirS
            // 
            misirS.Location = new Point(89, 71);
            misirS.Name = "misirS";
            misirS.Size = new Size(100, 23);
            misirS.TabIndex = 12;
            // 
            // biletS
            // 
            biletS.Location = new Point(89, 43);
            biletS.Name = "biletS";
            biletS.Size = new Size(100, 23);
            biletS.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(21, 161);
            label14.Name = "label14";
            label14.Size = new Size(23, 15);
            label14.TabIndex = 11;
            label14.Text = "Su:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 74);
            label12.Name = "label12";
            label12.Size = new Size(36, 15);
            label12.TabIndex = 10;
            label12.Text = "Mısır:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 132);
            label10.Name = "label10";
            label10.Size = new Size(30, 15);
            label10.TabIndex = 10;
            label10.Text = "Çay:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 74);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 9;
            label9.Text = "Mısır:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 100);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 8;
            label8.Text = "Süt:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 46);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 7;
            label6.Text = "Bilet:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(31, 118);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 238, 255);
            ClientSize = new Size(779, 356);
            Controls.Add(groupBox3);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Sineto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label label2;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label13;
        private Label label11;
        private Label label1;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox3;
        private MaskedTextBox maskedTextBox3;
        private LinkLabel linkLabel1;
        private ComboBox comboBox4;
        private ComboBox comboBox1;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label14;
        private Label label12;
        private Label label10;
        private Label label16;
        private Label label15;
        private Label lblToplam;
        private Button button1;
        private TextBox biletS;
        private TextBox suS;
        private TextBox cayS;
        private TextBox sutS;
        private TextBox misirS;
    }
}
