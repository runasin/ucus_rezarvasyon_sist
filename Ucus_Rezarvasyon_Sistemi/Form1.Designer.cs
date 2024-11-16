namespace Ucus_Rezarvasyon_Sistemi
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
            label9 = new Label();
            pictureBox2 = new PictureBox();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            listBox1 = new ListBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(39, 169);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 269);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uçuş Bilgileri";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(183, 22);
            label9.Name = "label9";
            label9.Size = new Size(45, 20);
            label9.TabIndex = 9;
            label9.Text = "label9";
            label9.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(305, 74);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(126, 201);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(173, 26);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 204);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 6;
            label4.Text = "Saat:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(126, 157);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(173, 26);
            dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 162);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 4;
            label3.Text = "Tarih:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Ankara", "Bursa", "Adana", "Van" });
            comboBox2.Location = new Point(126, 102);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(173, 28);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ankara", "Bursa", "Adana", "Van" });
            comboBox1.Location = new Point(126, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 28);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 105);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Nereye:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 57);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Nereden:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(467, 169);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(388, 269);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu Bilgileri";
            // 
            // button1
            // 
            button1.Location = new Point(230, 190);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 14;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(65, 138);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 13;
            label7.Text = "Telefon:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 95);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 12;
            label6.Text = "T.C. Kimlik No:";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(128, 135);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(177, 26);
            maskedTextBox3.TabIndex = 11;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(128, 89);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(177, 26);
            maskedTextBox2.TabIndex = 10;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(128, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 26);
            textBox1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 57);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 8;
            label5.Text = "Ad Soyad:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 464);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(878, 124);
            listBox1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(189, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 120);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(265, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(33, 42);
            label8.Name = "label8";
            label8.Size = new Size(206, 31);
            label8.TabIndex = 0;
            label8.Text = "Limon Hava Yolları";
            label8.Click += label8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Button button1;
        private Label label7;
        private Label label6;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox1;
        private Label label5;
        private ListBox listBox1;
        private Panel panel1;
        private Label label8;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label9;
    }
}
