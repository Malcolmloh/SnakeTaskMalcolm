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
    public partial class nameForm : Form
    {
        public nameForm()
        {
            InitializeComponent();
        }
        public string PlayerName
        {
            get { return nameTB.Text; }
        }

        private void nameForm_Load(object sender, EventArgs e)
        {

        }

        private void okBTN_Click(object sender, EventArgs e)
        {
            if (nameTB.Text != "")
            {
                this.DialogResult = DialogResult.OK; // Tell Form1 "We are good!"
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a name!");
            }
        }
    }
}
