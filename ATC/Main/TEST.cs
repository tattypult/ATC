using System;
using System.Windows.Forms;

namespace ATC
{
    public partial class TEST : Form
    {
        string fio;
        string FIO { get { return fio; } set { fio = value; } }
        string n_group;
        string N_group { get { return n_group; } set { n_group = value; } }
        public TEST()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.button1.Enabled = true;
            Program.form1.button2.Enabled = true;
            Program.form1.HiComBut.Enabled = true;
            Program.form1.DX_500But.Enabled = true;
            Program.form1.HipassBut.Enabled = true;
            Program.form1.T_76But.Enabled = true;
            Program.form1.bunifuButton1.Enabled = true;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new Information().Show();
            bunifuImageButton2.Enabled = false;
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            FIO = textBox1.Text;
            N_group = textBox2.Text;
            if (bunifuDropdown1.SelectedIndex == 0)
            {
                new HiCom(FIO, N_group).Show();
                this.Close();
            }
            if (bunifuDropdown1.SelectedIndex == 2)
            {
                new DX_500(FIO, N_group).Show();
                this.Close();
            }
            if (bunifuDropdown1.SelectedIndex == 1)
            {
                new HiPass(FIO, N_group).Show();
                this.Close();
            }
            if (bunifuDropdown1.SelectedIndex == 3)
            {
                new T_76(FIO, N_group).Show();
                this.Close();
            }
            if (bunifuDropdown1.SelectedIndex == 4)
            {
                new Alltests(FIO, N_group).Show();
                this.Close();
            }
        }
    }
}
