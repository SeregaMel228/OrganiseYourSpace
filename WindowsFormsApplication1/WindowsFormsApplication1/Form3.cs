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
            s = 1;
            m = 60 * s;
            h = 60 * m;
        }

        int s;
        int m;
        int h;

        //        h = Convert.ToInt32(textBox1.Text);
        //            m = Convert.ToInt32(textBox2.Text);
        //            s = Convert.ToInt32(textBox3.Text);

        //            timer1.Start();

        //h = Convert.ToInt32(textBox1.Text);
        //            m = Convert.ToInt32(textBox2.Text);
        //            s = Convert.ToInt32(textBox3.Text);

        //            timer1.Start()




        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }
        }
    }
}




//if (m==-1) 
//      {
//          h = h - 1;
//          m = 59;
//      }


//if (m == -1)
//        {
//            h = h - 1;
//            m = 59;
//        }
//    }



// if (h =0 && m=0 && s=0)

//     timer1.Stop();
//   MessageBox.Show("Время вышло!");}

//label1.Text = Convert.ToString(h);
//label3.Text = Convert.ToString(m);
//label5.Text = Convert.ToString(s);

//label1.Text = Convert.ToString(h);
//label3.Text = Convert.ToString(m);
//label5.Text = Convert.ToString(s);


//private void button2_Click(object sender, EventArgs e)

// timer1.Stop();


//private void button2_Click(object sender, EventArgs e)

// timer1.Stop();



//private void button3_Click(object sender, EventArgs e)

  //  timer1.Stop();
  //  label1.Text = "0";
   // label3.Text = "0";
   // label5.Text = "0";

//private void button3_Click(object sender, EventArgs e)

   // timer1.Stop();
   // label1.Text = "0";
  //  label3.Text = "0";
  //  label5.Text = "0";


