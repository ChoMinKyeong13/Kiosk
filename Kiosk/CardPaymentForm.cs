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
    public partial class CardPaymentForm : Form
    {
        private int totalAmount;
        public CardPaymentForm(int total)
        {
            InitializeComponent();
            totalAmount = total;
        }



        private void CardPaymentForm_Load(object sender, EventArgs e)
        {
            lblAmount.Text = $"결제 금액: {totalAmount}원";

            // 카드사 목록
            comboBox_CardCompany.Items.Clear();
            comboBox_CardCompany.Items.AddRange(new string[]
            {
                "국민카드", "삼성카드", "우리카드", "신한카드", "농협카드"
            });
            comboBox_CardCompany.SelectedIndex = 0; // 기본값 첫 번째로 0

            // 할부 개월 목록 적디
            comboBox_Installment.Items.Clear();
            comboBox_Installment.Items.AddRange(new string[]
            {
                "일시불", "2개월", "3개월", "6개월", "12개월"
            });
            comboBox_Installment.SelectedIndex = 0;

            checkBox_Agree.Checked = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (comboBox_CardCompany.SelectedItem == null)
            {
                MessageBox.Show("카드사를 선택해주세요.");
                return;
            }

            if (comboBox_Installment.SelectedItem == null)
            {
                MessageBox.Show("할부 개월을 선택해주세요.");
                return;
            }

            if (!checkBox_Agree.Checked)
            {
                MessageBox.Show("개인정보 수집 및 이용에 동의해주세요.");
                return;
            }

            string cardCompany = comboBox_CardCompany.SelectedItem.ToString();
            string installment = comboBox_Installment.SelectedItem.ToString();

            MessageBox.Show($"{cardCompany} / {installment} 결제 승인되었습니다.");

            this.DialogResult = DialogResult.OK; // PaymentForm에 성공 신호 전달
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
