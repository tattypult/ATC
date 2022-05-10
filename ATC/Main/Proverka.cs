using System;
using System.Windows.Forms;

namespace ATC
{
    public partial class Proverka : Form
    {
        public Proverka()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "SSPI_SUPER")
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
            else
            {
                textBox1.Clear();
                MessageBox.Show("Давай-ка подумай дружочек");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
        }
    }
}
