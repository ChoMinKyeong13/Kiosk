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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Kiosk
{
    public partial class RamenForm : Form
    {
        private Member currentMember;
       // private List<Product> cart = new List<Product>();
        public RamenForm(Member member)
        {
            InitializeComponent();
            currentMember = member;
        }

        private void RamenForm_Load(object sender, EventArgs e)
        {
            var products = Productstore.GetByCategory("라면");
            PictureBox[] pictureBoxes = new PictureBox[]
            {
                    p1, p2, p3, p4,
                    p5, p6, p7, p8
            };

            for (int i = 0; i < pictureBoxes.Length && i < products.Count; i++)
            {
                pictureBoxes[i].Tag = products[i];
                pictureBoxes[i].Click += Product_Click;
            }
           
        }
        private void Product_Click(object sender, EventArgs e)
        {
            PictureBox clicked = sender as PictureBox;
            if (clicked?.Tag is Product product)
            {
                Cartstore.Add(product);   // 모든 폼이 공유하는 창고에 추가
                MessageBox.Show($"{product.Name} 담았습니다. (현재 {Cartstore.GetItems().Count}개)");
            }
        }
        

        private void Cart_Click(object sender, EventArgs e)
        {
            Cartform cartForm = new Cartform(currentMember);
            cartForm.ShowDialog();
        }

       
    }
}
