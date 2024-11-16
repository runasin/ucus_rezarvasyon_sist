namespace Ucus_Rezarvasyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + " - " + comboBox2.Text + "  " + "Tarih: " + dateTimePicker1.Text + "  " + "Saat: " + maskedTextBox1.Text + "  |  " + "Yolcu Bilgileri ~ Ad Soyad: " + textBox1.Text + " " + " T.C.: " + maskedTextBox2.Text + "  " + " Telefon: " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu kaydý baþarýlý");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;
        }
    }
}
