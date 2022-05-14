using System;
using System.Drawing;
using System.Windows.Forms;

namespace ATC
{


    public partial class Form1 : Form
    {

        double paneilwidth;
        bool hidden;
        double loc = 156;
        public Form1()
        {
            InitializeComponent();
            timer1 = new Timer();
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, 5);
            timer1.Interval = (int)ts.TotalMilliseconds;
            timer1.Tick += Timer_Tick;
            paneilwidth = panel1.Width;
            Program.form1 = this;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            if (hidden)
            {
                button3.Location = new Point((int)(loc - 1), 60);
                loc = loc + 1;
                panel1.Width += 1;
                if (panel1.Width > paneilwidth)
                {
                    timer1.Stop();
                    hidden = false;
                }
            }
            else
            {
                button3.Location = new Point((int)(loc + 1), 60);
                loc = loc - 1;
                panel1.Width -= 1;
                if (panel1.Width <= 40)
                {
                    timer1.Stop();
                    hidden = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            new TEST().Show();
            button1.Enabled = false;
            button2.Enabled = false;
            bunifuButton1.Enabled = false;
            HiComBut.Enabled = false;
            DX_500But.Enabled = false;
            HipassBut.Enabled = false;
            T_76But.Enabled = false;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            new AboutProgram().Show();
            bunifuButton2.Enabled = false;
        }

        private void DX_500But_Click(object sender, EventArgs e)
        {
            new TDX_500().Show();
            DX_500But.Enabled = false;
            bunifuButton1.Enabled = false;
        }

        private void HiComBut_Click(object sender, EventArgs e)
        {
            new THicom().Show();
            HiComBut.Enabled = false;
            bunifuButton1.Enabled = false;
        }

        private void T_76But_Click(object sender, EventArgs e)
        {
            new TT_76().Show();
            T_76But.Enabled = false;
            bunifuButton1.Enabled = false;
        }

        private void HipassBut_Click(object sender, EventArgs e)
        {
            new THipass().Show();
            HipassBut.Enabled = false;
            bunifuButton1.Enabled = false;
        }
    }
}
