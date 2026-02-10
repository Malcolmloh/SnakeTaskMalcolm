using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void infoText_TextChanged(object sender, EventArgs e)
        {

        }

        private void backtomenuBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
