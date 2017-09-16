using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        

        {
            InitializeComponent();
            
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> name = new Dictionary<string, string>();
            Dictionary<string, string> mass = new Dictionary<string, string>();
            Dictionary<string, string> press = new Dictionary<string, string>();
            Dictionary<string, string> habit = new Dictionary<string, string>();
            Dictionary<string, string> sience = new Dictionary<string, string>();
            name.Add("Зира", "");
            name.Add("Мпорт", "");
            name.Add("Фасп", "");
            name.Add("Моран", "");
            name.Add("Ка сп","");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
