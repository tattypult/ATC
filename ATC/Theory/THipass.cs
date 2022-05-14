using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATC
{
    public partial class THipass : Form
    {
        public THipass()
        {
            InitializeComponent();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.HipassBut.Enabled = true;
            Program.form1.bunifuButton1.Enabled = true;
        }
    }
}
