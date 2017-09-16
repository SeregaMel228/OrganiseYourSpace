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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.textBox1.Text = "Нибуру";
            form.textBox2.Text = "5•10^24";
            form.textBox3.Text = "~156 Па";
            form.textBox4.Text = "Монстры";
            form.textBox5.Text = "Изучена на 15%";
            form.Show();
        }
        

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            pictureBox9.Size = new Size(160, 155);

        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox9.Size = new Size(130, 135);
        }

        

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(148, 139);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(118, 109);
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(167, 169);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Size = new Size(137, 139);
        }

        

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(190, 194);
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Size = new Size(160, 164);
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(159, 149);
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Size = new Size(129, 119);

        }

        

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(208, 203);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(178, 173);
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            
            pictureBox7.Size = new Size(88, 90);
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Size = new Size(58, 60);

        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.textBox1.Text = "Мируеки";
            form.textBox2.Text = "6•10^24";
            form.textBox3.Text = "~135 Па";
            form.textBox4.Text = "Микробы и бактерии";
            form.textBox5.Text = "Изучена на 6%";
            form.Show();
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.textBox1.Text = "Бетурум";
            form.textBox2.Text = "2•10^24";
            form.textBox3.Text = "~143 Па";
            form.textBox4.Text = "Микробы и бактерии";
            form.textBox5.Text = "Изучена на 10%";
            form.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.textBox1.Text = "Земля";
            form.textBox2.Text = "6•10^24";
            form.textBox3.Text = "~133 Па";
            form.textBox4.Text = "Люди, животные и др.";
            form.textBox5.Text = "Изучена на 74%";
            form.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.textBox1.Text = "Маджипур";
            form.textBox2.Text = "5•10^24";
            form.textBox3.Text = "~146 Па";
            form.textBox4.Text = "Морская фауна";
            form.textBox5.Text = "Изучена на 9%";
            form.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.textBox1.Text = "Юггот";
            form.textBox2.Text = "7•10^24";
            form.textBox3.Text = "~123 Па";
            form.textBox4.Text = "Монстры";
            form.textBox5.Text = "Изучена на 12%";
            form.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.textBox1.Text = "Шелизяка";
            form.textBox2.Text = "4.5•10^24";
            form.textBox3.Text = "~135 Па";
            form.textBox4.Text = "Роботы";
            form.textBox5.Text = "Изучена на 16%";
            form.Show();
        }
    }
}
