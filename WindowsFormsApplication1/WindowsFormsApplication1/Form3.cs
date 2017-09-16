using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        {
        h = Convert.ToInt32(textBox1.Text);
            m = Convert.ToInt32(textBox2.Text);
            s = Convert.ToInt32(textBox3.Text);

            timer1.Start();
            1
2
3
4
5
h = Convert.ToInt32(textBox1.Text);
            m = Convert.ToInt32(textBox2.Text);
            s = Convert.ToInt32(textBox3.Text);

            timer1.Start()


        }

    private void timer1_Tick(object sender, EventArgs e)
    {
        s = s - 1;
        if (s == -1)
        {
            m = m - 1;
            s = 59;
        }
    }
    

if (m==-1) 
      {
          h = h - 1;
          m = 59;
      }
1
2
3
4
5
if (m==-1) 
      {
          h = h - 1;
          m = 59;
      }
}
