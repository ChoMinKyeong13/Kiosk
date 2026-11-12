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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string id = textBox_Id.Text.Trim();
            string name = textBox_Name.Text.Trim();
            string tel = textBox_Tel.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("이름과 회원번호는 필수입니다.");
                return;
            }

            Member newMember = new Member
            {
                MemberId = id,
                Name = name,
                Tel = tel,
                JoinDate = DateTime.Now,
                Points = 0,
                Grade = "일반",
                Birthday = null
            };

            bool success = Memberstore.InsertMember(newMember);

            if (success)
            {
                MessageBox.Show("등록 완료!");
                textBox_Id.Clear();
                textBox_Name.Clear();
                textBox_Tel.Clear();
                this.Close();
            }
            else
            {
                MessageBox.Show("이미 존재하는 회원번호입니다.");
            }
            
        }
    }
}
