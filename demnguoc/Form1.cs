using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demnguoc
{
    public partial class Form1 : Form
    {
        int time;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            time = Convert.ToInt32(this.textBox1.Text) + 1;
            this.textBox1.Visible = false;
            this.label1.Visible = false;
            this.button1.Visible = false;
            this.button2.Visible = true;
            this.timer1.Interval = 1000;
            this.timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time == 0)
            {
                this.label2.Text = "Hết giờ";
                this.timer1.Enabled = false;
                this.label2.Visible = true;
            }
            else
            {
                time = time - 1;
                this.label2.Text = Convert.ToString(time);
                this.label2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Visible = false;
            this.label2.Visible = false;
            this.label1.Visible = true;
            this.button1.Visible = true;
            this.textBox1.Visible = true;
        }
    }
}
