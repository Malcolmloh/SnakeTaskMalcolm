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
    public partial class confirmexit : Form
    {
        public confirmexit()
        {
            InitializeComponent();
        }

        private void quitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
