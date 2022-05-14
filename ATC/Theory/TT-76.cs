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
    public partial class TT_76 : Form
    {
        public TT_76()
        {
            InitializeComponent();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.T_76But.Enabled = true;
            Program.form1.bunifuButton1.Enabled = true;
        }
    }
}
