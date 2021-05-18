using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aum_launcher
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void MenuAbout_MenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Things");
        }
    }
}
