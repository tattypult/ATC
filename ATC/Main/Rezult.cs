using System;
using System.Windows.Forms;

namespace ATC
{
    public partial class Rezult : Form
    {
        Proverka proverka;
        public Rezult()
        {
            InitializeComponent();
            proverka = new Proverka();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            proverka.Show();
        }

    }
}
