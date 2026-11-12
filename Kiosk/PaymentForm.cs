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
    public partial class PaymentForm : Form
    {
        private Member currentMember;
        private int totalAmount;
        public PaymentForm(Member member, int total)
        {
            InitializeComponent();
            currentMember = member;
            totalAmount = total;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            listBox_CartItems.Items.Clear();
            foreach (var p in Cartstore.GetItems())
            {
                listBox_CartItems.Items.Add($"{p.Name} - {p.Price}원");
            }

            lblAmount.Text = $"결제 금액: {totalAmount}원";
            lblMyPoints.Text = $"보유 포인트: {currentMember.Points}P";
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            CardPaymentForm cardForm = new CardPaymentForm(totalAmount);
            DialogResult result = cardForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                ProcessPayment("카드");
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (currentMember.Points < totalAmount)
            {
                MessageBox.Show("보유 포인트가 부족합니다.");
                return;
            }

            ProcessPayment("포인트");
        }
        private void ProcessPayment(string method)
        {
            if (method == "포인트")
            {
                Memberstore.UpdatePoints(currentMember.MemberId, -totalAmount);
            }

            int earnedPoints = (int)(totalAmount * 0.05);
            Memberstore.UpdatePoints(currentMember.MemberId, earnedPoints);

            Cartstore.Clear();

            MessageBox.Show($"{method} 결제 완료!\n{totalAmount}원 결제되었고, {earnedPoints}P가 적립되었습니다.");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
