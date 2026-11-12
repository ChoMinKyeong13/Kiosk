using MySqlX.XDevAPI.Relational;
using System.Diagnostics.Metrics;

namespace Kiosk
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string inputId = txtMemberId.Text.Trim();

            if (string.IsNullOrEmpty(inputId))
            {
                MessageBox.Show("회원번호를 입력해주세요.");
                return;
            }

            Member member = Memberstore.GetMember(inputId);

            if (member == null)
            {
                MessageBox.Show("존재하지 않는 회원번호입니다.");
                Register register = new Register();
                register.ShowDialog();
                return;

            }

            MessageBox.Show($"환영합니다, {member.Name}님! (등급: {member.Grade}, 포인트: {member.Points}P)");




            Categoryform categoryform = new Categoryform(member);
            categoryform.Show();
            this.Hide();
        }

        
    }
}
