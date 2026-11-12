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
    public partial class Cartform : Form
    {
        private Member currentMember;
        public Cartform(Member member)
        {
            InitializeComponent();
            currentMember = member;
        }

        private void Cartform_Load(object sender, EventArgs e)
        {
            RefreshCart();
        }
        private void RefreshCart()
        {
            listBox_Cart.Items.Clear();
            foreach (var p in Cartstore.GetItems())
            {
                listBox_Cart.Items.Add($"{p.Name} - {p.Price}원");
            }

            int total = Cartstore.GetTotal();
            lblTotal.Text = $"합계: {total}원";
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            int index = listBox_Cart.SelectedIndex;

            if (index == -1)
            {
                MessageBox.Show("삭제할 상품을 선택해주세요.");
                return;
            }

            Cartstore.RemoveAt(index);
            RefreshCart();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (Cartstore.GetItems().Count == 0)
            {
                MessageBox.Show("장바구니가 비어있습니다.");
                return;
            }
            int total = Cartstore.GetTotal();
            PaymentForm paymentForm = new PaymentForm(currentMember, total);
            DialogResult result = paymentForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // 결제 성공했으면 CartForm도 닫고 카테고리 화면으로 복귀
                this.Close();
            }
            else
            {
                // 결제 취소했으면 장바구니 화면 유지, 목록 갱신만
                RefreshCart();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
