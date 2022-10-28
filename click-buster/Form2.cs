using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace click_buster
{
    public partial class F_Main : Form
    {
        public F_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void F_Main_Load(object sender, EventArgs e)
        {

        }

        private void F_Main_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
