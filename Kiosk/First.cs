using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        private void First_Click(object sender, EventArgs e)
        {
            MainFrom m = new MainFrom();
            m.Show();
            this.Hide();
        }
    }
}
