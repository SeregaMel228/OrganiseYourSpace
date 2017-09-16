using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace OYS
{
    public partial class Form1 : Form
    {
        public Form1()
        

        {
            InitializeComponent();
            
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.textBox1.Text = "Шелизяка";
            form.textBox2.Text = "10^24";
            form.textBox3.Text = "~147 Па";
            form.textBox4.Text = "Роботы";
            form.textBox5.Text = "Изучена на 3%";
            form.Show();
        }        

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.textBox1.Text = "Нибуру";
            form.textBox2.Text = "10^24";
            form.textBox3.Text = "~156 Па";
            form.textBox4.Text = "Монстры";
            form.textBox5.Text = "Изучена на 15%";
            form.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.textBox1.Text = "Юггот";
            form.textBox2.Text = "10^24";
            form.textBox3.Text = "~163 Па";
            form.textBox4.Text = "Микробы";
            form.textBox5.Text = "Изучена на 50%";
            form.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.textBox1.Text = "Маджипур";
            form.textBox2.Text = "10^24";
            form.textBox3.Text = "~124 Па";
            form.textBox4.Text = "Животные";
            form.textBox5.Text = "Изучена на 63%";
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.textBox1.Text = "Земля";
            form.textBox2.Text = "5,9726·10^24";
            form.textBox3.Text = "~133 Па";
            form.textBox4.Text = "Люди, животные, бактерии и др.";
            form.textBox5.Text = "Изучена на 74%";
            form.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.textBox1.Text = "Бетурум";
            form.textBox2.Text = "10^24";
            form.textBox3.Text = "~143 Па";
            form.textBox4.Text = "Микробы и бактерии";
            form.textBox5.Text = "Изучена на 10%";
            form.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.textBox1.Text = "Мируеки";
            form.textBox2.Text = "10^24 ";
            form.textBox3.Text = "~135 Па";
            form.textBox4.Text = "Рыбы";
            form.textBox5.Text = "Изучена на 34%";
            form.Show();
        }
    }
}
