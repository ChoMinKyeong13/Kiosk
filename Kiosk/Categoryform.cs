using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class Categoryform : Form
    {
        private Member currentMember;

        public Categoryform(Member member)
        {
            InitializeComponent();
            currentMember = member;
        }

        private void burger_Click(object sender, EventArgs e)
        {
            BurgerForm form = new BurgerForm(currentMember);
            form.ShowDialog();
        }

        private void rice_Click(object sender, EventArgs e)
        {
            RiceForm form = new RiceForm(currentMember);
            form.ShowDialog();
        }

        private void ramen_Click(object sender, EventArgs e)
        {
            RamenForm form = new RamenForm(currentMember);
            form.ShowDialog();
        }

        private void snack_Click(object sender, EventArgs e)
        {
            SnackForm form = new SnackForm(currentMember);
            form.ShowDialog();
        }

        private void drink_Click(object sender, EventArgs e)
        {
            DrinkForm form = new DrinkForm(currentMember);
            form.ShowDialog();
        }

        private void icecream_Click(object sender, EventArgs e)
        {
            IceCreamForm form = new IceCreamForm(currentMember);
            form.ShowDialog();
        }

        
    }
}
