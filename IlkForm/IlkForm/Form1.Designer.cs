namespace IlkForm
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
            Test2 = new Label();
            label1 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Test2
            // 
            Test2.AutoSize = true;
            Test2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Test2.Location = new Point(131, 128);
            Test2.Name = "Test2";
            Test2.Size = new Size(51, 29);
            Test2.TabIndex = 0;
            Test2.Text = "Ad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(104, 159);
            label1.Name = "label1";
            label1.Size = new Size(87, 29);
            label1.TabIndex = 1;
            label1.Text = "Soyad:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(154, 288);
            button1.Name = "button1";
            button1.Size = new Size(107, 32);
            button1.TabIndex = 2;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(50, 332);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(404, 64);
            listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 136);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(194, 165);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(114, 194);
            label2.Name = "label2";
            label2.Size = new Size(60, 28);
            label2.TabIndex = 0;
            label2.Text = "Yaş:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(101, 223);
            label3.Name = "label3";
            label3.Size = new Size(114, 29);
            label3.TabIndex = 0;
            label3.Text = "Nereden:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(87, 254);
            label4.Name = "label4";
            label4.Size = new Size(104, 31);
            label4.TabIndex = 0;
            label4.Text = "Nereye:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(194, 194);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Adana", "İstanbul", "Artvin", "İzmir ", "Bakü", "Ardanuc" });
            comboBox1.Location = new Point(194, 223);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Adana", "İstanbul", "Artvin", "İzmir ", "Bakü", "Ardanuc" });
            comboBox2.Location = new Point(194, 259);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe Script", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(154, 38);
            label5.Name = "label5";
            label5.Size = new Size(145, 38);
            label5.TabIndex = 6;
            label5.Text = "İlk puroje:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-97, -95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(737, 606);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(478, 408);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Test2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "yaş";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Test2;
        private Label label1;
        private Button button1;
        private ListBox listBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label5;
        private PictureBox pictureBox1;
    }
}
